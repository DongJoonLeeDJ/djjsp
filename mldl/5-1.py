import pandas as pd
import numpy as np

from sklearn.model_selection import train_test_split
from sklearn.preprocessing import StandardScaler
from sklearn.linear_model import LogisticRegression
from sklearn.tree import DecisionTreeClassifier
import matplotlib.pyplot as plt
from sklearn.tree import plot_tree

wine = pd.read_csv('https://bit.ly/wine_csv_data')
'''
pandas 라이브러리는 csv 파일을 읽으면
데이터프레임 객체로 반환을 해줍니다.
'''
print(wine.head())
print(wine.info())
print(wine.describe())

data = wine[['alcohol', 'sugar', 'pH']].to_numpy()
target = wine['class'].to_numpy()

'''
지도 학습  ,  비지도학습
머신러닝 5장(treeClassfier) , 6장...
딥러닝
7장...
'''
train_input, test_input, train_target, test_target = train_test_split(
    data, target, random_state=42
)

ss = StandardScaler()
ss.fit(train_input)

train_scaled = ss.transform(train_input)
test_scaled = ss.transform(test_input)

lr = LogisticRegression()
lr.fit(train_scaled, train_target)

train_score = lr.score(train_scaled, train_target)
test_score = lr.score(test_scaled, test_target)

print('훈련점수', train_score, '테스트점수', test_score)
# 9.4,1.9,3.51 -> 0

preclass = lr.predict(
    ss.transform(
        [
            [9.4, 1.9, 3.51], [9.9, 1.6, 3.58], [12.2, 4.45, 3.25],
            [11.066666666666698,2.2,3.32]
         ]
    )
)
print('예측값', preclass)

dtclf = DecisionTreeClassifier(max_depth=3)
dtclf.fit(train_scaled,train_target)

train_score = dtclf.score(train_scaled, train_target)
test_score = dtclf.score(test_scaled, test_target)

print('훈련점수', train_score, '테스트점수', test_score)
# 9.4,1.9,3.51 -> 0

preclass = dtclf.predict(
    ss.transform(
        [
            [9.4, 1.9, 3.51], [9.9, 1.6, 3.58], [12.2, 4.45, 3.25],
            [11.066666666666698,2.2,3.32]
         ]
    )
)
print("예측된값 ",preclass)




# plt.figure(figsize=(10,7),dpi=50)
# plot_tree(dtclf)
# plt.show()

plt.figure(figsize=(10,7))
plot_tree(dtclf, max_depth=1, filled=True, feature_names=['alcohol', 'sugar', 'pH'])
# plt.show()

print(dtclf.feature_importances_)

'''
dtclf = DecisionTreeClassifier(max_depth=3)
dtclf.fit()
dtclf = DecisionTreeClassifier(max_depth=4)
dtclf.fit()
dtclf = DecisionTreeClassifier(max_depth=5)
dtclf.fit()
'''

'''
5-1
 -> 3가지 변수(알콜,슈가,ph)
 -> 0,1 인지 분류하는 것..
 
 logisticRegession
 분류... 78점..
 
 DecisionTreeClassfier
 결정트리분류기...
 85점...
 깊이 3~10
 최소불순도감소 0.0001~0.1
 
 머신러닝,딥러닝
 학습기로 학습을.. 예측데이터값을 제일 정확하게 만드는 개발...
 
 교차검증... 하이퍼파라메타 튜닝.. 
'''