import numpy as np
import pandas as pd
from sklearn.model_selection import train_test_split
from sklearn.model_selection import cross_validate
from sklearn.ensemble import RandomForestClassifier
from sklearn.ensemble import ExtraTreesClassifier

wine = pd.read_csv('https://bit.ly/wine_csv_data')

data = wine[['alcohol', 'sugar', 'pH']].to_numpy()
target = wine['class'].to_numpy()

train_input, test_input, train_target, test_target \
    = train_test_split(data, target, test_size=0.2, random_state=42)

rfclf = RandomForestClassifier(n_jobs=-1,random_state=42)
cv = cross_validate(rfclf,train_input,train_target,
                    return_train_score=True, n_jobs=-1)

print(cv)
print('훈련데이터 평균점수 = ',np.mean(cv['train_score']))
print('테스트 평균점수 = ',np.mean(cv['test_score']))

# print(rfclf.predict([[9.4,1.6,3.3]]))
rfclf.fit(train_input,train_target)
print(rfclf.predict([[9.4,1.6,3.3]]))

exclf = ExtraTreesClassifier(n_jobs=-1,random_state=42)
excv = cross_validate(exclf,train_input,train_target,
                    return_train_score=True, n_jobs=-1)

print(cv)
print('훈련데이터 평균점수 = ',np.mean(excv['train_score']))
print('테스트 평균점수 = ',np.mean(excv['test_score']))

# print(rfclf.predict([[9.4,1.6,3.3]]))
exclf.fit(train_input,train_target)
print(exclf.predict([[9.4,1.6,3.3]]))



