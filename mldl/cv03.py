import cv2
import matplotlib.pyplot as plt

import speech_recognition as sr
from gtts import gTTS
import os
import time
import playsound

img = cv2.imread('main.jpg', cv2.IMREAD_COLOR)
# cv2.imshow('main',img)
# cv2.waitKey(0)

# img_resize = cv2.resize(img, None, fx=2.0, fy=2.0, interpolation=cv2.INTER_CUBIC);
# cv2.imshow('main', img_resize)
# cv2.waitKey(0)

# img_resize = cv2.resize(img, None, fx=0.3, fy=0.3, interpolation=cv2.INTER_AREA);
# cv2.imshow('main', img_resize)
# cv2.waitKey(0)

print(img.shape)
# 좌표, 각도, 배율
for i in range(0, 360, 10):
    M = cv2.getRotationMatrix2D((img.shape[0] / 2, img.shape[1] / 2), i, 0.5)

    # warpAffine 이미지를 변형하는 함수
    mimg = cv2.warpAffine(img, M, (img.shape[0], img.shape[1]))
    filename = './aimg/a' + str(i) + '.jpg'
    # print(filename);
    '''
    머신러닝, 딥러닝.. 
    학습할 이미지가 모자를때 각도를 변형해서 여러 이미지로 파일 만들때...
    '''
    cv2.imwrite(filename, mimg)
    # cv2.imshow('mimg', mimg)
    # cv2.waitKey(0)

'''
이미지를 고객이 많이... 안줄때...

스프링 프로젝트...
()

pip install speechrecognition
pip install playsound 
pip install gtts
음성 -> text 
text -> 음성
'''
# def speak(text):
#     tts = gTTS(text=text, lang='ko')
#     filename='voice.mp3'
#     tts.save(filename)
#     playsound.playsound(filename)
#
# speak("3시 41분 입니다. 45분에 시작하죠")
