#-------------------------------------------------------------------------------
# Name:        module1
# Purpose:
#
# Author:      Saqib
#
# Created:     08/11/2014
# Copyright:   (c) Saqib 2014
# Licence:     <your licence>
#-------------------------------------------------------------------------------

from flask import Flask ,jsonify
from flask import make_response
from flask import request
from nltk import word_tokenize,WordNetLemmatizer,NaiveBayesClassifier,classify,MaxentClassifier
from nltk.corpus import stopwords
from nltk.tokenize import RegexpTokenizer
import json
import nltk
import pickle

app = Flask(__name__)

tweets = []
classifier = nltk.NaiveBayesClassifier
email_classifier = nltk.NaiveBayesClassifier

@app.route('/todo/api/v1.0/trainingset', methods = ['POST'])
def create_trainingset():
    data_string =  json.dumps(request.json)
    tweets_data =  json.loads(data_string)
    for item in tweets_data:
        words_filtered = [e.lower() for e in item['key'].split() if len(e) >= 3]
        tweets.append((words_filtered, item['value']))

    print 'create_trainingset done'
    return jsonify({ 'Status':'Training Set Build' }), 201

@app.route('/todo/api/v1.0/features',methods = ['GET'])
def get_features():
    global word_features
    word_features = get_word_features(get_words_in_tweets(tweets))
    print 'get_features done'
    return jsonify({ 'Status':'Feature word Get' }), 200

@app.route('/todo/api/v1.0/buildtrainset',methods = ['GET'])
def get_buildtrainset():
    training_set = nltk.classify.apply_features(extract_features, tweets)
    global classifier
    classifier = nltk.NaiveBayesClassifier.train(training_set)
    print 'get_buildtrainset done'
    return jsonify({ 'Status':'Training set Build' }), 200

@app.route('/todo/api/v1.0/sentiments', methods = ['POST'])
def get_sentiments():
    data_string =  json.dumps(request.json)
    test_tweets_data =  json.loads(data_string)
##    print 'test tweets ----> ',test_tweets_data
    tweets_sentiment = []
    for tweet in test_tweets_data:
        sentiment = classifier.classify(extract_features(tweet['value'].split()))
        print sentiment
        tweets_sentiment.append((tweet['key'],sentiment))

    print 'get_sentiments done', tweets_sentiment
    return jsonify(tweets_sentiment)

@app.route('/todo/api/v1.0/classifyemail', methods = ['POST'])
def get_classifyemail():
    data_string =  json.dumps(request.json)
    email_data =  json.loads(data_string)

    print 'email data ----> ',email_data

    featset = email_features(email_data)

    print 'featset ----> ',featset

    classify = email_classifier.classify(featset)
    print 'get_classifyemail done', classify
    return classify

def get_words_in_tweets(tweets):
    all_words = []
    for (words, sentiment) in tweets:
      all_words.extend(words)
    return all_words

def get_word_features(wordlist):
    wordlist = nltk.FreqDist(wordlist)
    word_features = wordlist.keys()
    return word_features

def extract_features(document):
    document_words = set(document)
    features = {}
    for word in word_features:
      features['contains(%s)' % word] = (word in document_words)
    return features

def email_features(sent):

    print 'in email_features ---> '

    commonwords = stopwords.words('english')
    wordlemmatizer = WordNetLemmatizer()

    print 'commonwords and wordlemmatizer'

    features = {}
    tokenizer = RegexpTokenizer(r'\w+')
    tokens =  tokenizer.tokenize(sent)

    print 'tokens ---> ', tokens

    wordtokens = [wordlemmatizer.lemmatize(x.lower()) for x in tokens if x not in stopwords.words('english') and len(x) > 1 and x.isalpha()]
    for word in wordtokens:
		if word not in commonwords:
			features[word] =  True

    return features

def load_classifier_from_file():
    f = open('naviebayes_classifier.pickle')
    global email_classifier
    email_classifier = pickle.load(f)
    f.close()

if __name__ == '__main__':
    load_classifier_from_file()
    app.run()