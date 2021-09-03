import pandas as pd
from sklearn.model_selection import train_test_split
from sklearn.tree import DecisionTreeClassifier
from sklearn.model_selection import cross_validate
from sklearn.model_selection import StratifiedKFold
from sklearn.model_selection import GridSearchCV
import numpy as np

wine = pd.read_csv('https://bit.ly/wine_csv_data')

data = wine[['alcohol', 'sugar', 'pH']].to_numpy()
target = wine['class'].to_numpy()

# print(data.shape)

train_input, test_input, train_target, test_target = train_test_split(
    data, target, test_size=0.2, random_state=42)

# print(train_input.shape)
# print(test_input.shape)

sub_input, val_input, sub_target, val_target = train_test_split(
    train_input, train_target, test_size=0.2, random_state=42)

# print(sub_input.shape, val_input.shape)

dt = DecisionTreeClassifier(max_depth=7,random_state=42)
dt.fit(sub_input,sub_target)

subscore = dt.score(sub_input,sub_target)
valscore = dt.score(val_input,val_target)

print('subscore = ',subscore,'valscore = ',valscore)

scores = cross_validate(dt, train_input, train_target)
print(scores)

print(np.mean(scores['test_score']))

sk = StratifiedKFold()
scores = cross_validate(dt, train_input, train_target,cv=sk)
print(scores)

sk = StratifiedKFold(n_splits=10, shuffle=True, random_state=42)
scores = cross_validate(dt, train_input, train_target, cv=sk)
print(scores)

# for i in range(0.001,0.006,0.001):
#     dclf = DecisionTreeClassifier(min_impurity_decrease=i)
#     dclf.fit(sub_input,sub_target)
#
#     print(dclf.score(val_input,val_target))
#
params = {'min_impurity_decrease': [0.0001, 0.0002, 0.0003, 0.0004, 0.0005]}

# list = [1,2,3,4,5]

gs = GridSearchCV(DecisionTreeClassifier(random_state=42),params,n_jobs=-1)
gs.fit(sub_input,sub_target)

dt = gs.best_estimator_

print(dt.score(val_input,val_target))
print(gs.best_params_)

params = {
        'min_impurity_decrease': np.arange(0.0001, 0.001, 0.0001),
        'max_depth': range(5, 20, 1),
        'min_samples_split': range(2, 100, 10)
          }

gs = GridSearchCV(DecisionTreeClassifier(random_state=42), params, n_jobs=-1)
gs.fit(train_input, train_target)

print(gs.best_estimator_.score(test_input,test_target))
print(gs.best_params_)