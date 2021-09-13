import pandas as pd
import numpy as np

import matplotlib.pyplot as plt
from matplotlib.widgets import Lasso

from sklearn.model_selection import train_test_split
from sklearn.preprocessing import PolynomialFeatures
from sklearn.preprocessing import StandardScaler
from sklearn.linear_model import LinearRegression
from sklearn.linear_model import Ridge
from sklearn.linear_model import Lasso

df = pd.read_csv('https://bit.ly/perch_csv_data')
perch_full = df.to_numpy()
print(perch_full)
'''
 pip install pandas
'''
perch_weight = np.array(
    [5.9, 32.0, 40.0, 51.5, 70.0, 100.0, 78.0, 80.0, 85.0, 85.0,
     110.0, 115.0, 125.0, 130.0, 120.0, 120.0, 130.0, 135.0, 110.0,
     130.0, 150.0, 145.0, 150.0, 170.0, 225.0, 145.0, 188.0, 180.0,
     197.0, 218.0, 300.0, 260.0, 265.0, 250.0, 250.0, 300.0, 320.0,
     514.0, 556.0, 840.0, 685.0, 700.0, 700.0, 690.0, 900.0, 650.0,
     820.0, 850.0, 900.0, 1015.0, 820.0, 1100.0, 1000.0, 1100.0,
     1000.0, 1000.0]
)

train_input, test_input, train_target, test_target = \
    train_test_split(perch_full, perch_weight, random_state=42)

lr = LinearRegression()
lr.fit(train_input, train_target)

train_score = lr.score(train_input, train_target)
test_score = lr.score(test_input, test_target)

print("훈련데이터로 알고리즘 점수 = ", train_score)
print("테스트데이터로 알고리즘 점수 = ", test_score)

prevalues = lr.predict([[44, 12.49, 7.6], [8.4, 2.11, 1.41], [10, 20, 30]])
# print('prevalues = ', prevalues)

'''
    kolnpy 라이브러리..
    naver, gmarket, news
    냉장고, 식기세척기, 세탁기
    -> 텔레비전, 
    영화리뷰..
    나는 이영화 좋아 -> 긍정
    나는 이영화 시러 -> 부정
    배우 누구 좋아 -> 긍정
'''

poly = PolynomialFeatures(include_bias=False)
poly.fit(train_input)
# print("train_input.shape=", train_input.shape)
train_poly = poly.transform(train_input)
test_poly = poly.transform(test_input)
# print("5개 출력")
# print(train_input[0])
# print(train_poly[0])
# print(poly.get_feature_names())

lr = LinearRegression()
lr.fit(train_poly, train_target)

train_score = lr.score(train_poly, train_target)
test_score = lr.score(test_poly, test_target)

print("훈련데이터로 알고리즘 점수 = ", train_score)
print("테스트데이터로 알고리즘 점수 = ", test_score)

poly = PolynomialFeatures(degree=5, include_bias=False)
poly.fit(train_input, train_target)

train_poly = poly.transform(train_input)
test_poly = poly.transform(test_input)

# print(poly.get_feature_names())
# print(train_poly.shape)

lr = LinearRegression()
lr.fit(train_poly, train_target)

train_score = lr.score(train_poly, train_target)
test_score = lr.score(test_poly, test_target)

print("훈련데이터로 알고리즘 점수 = ", train_score)
print("테스트데이터로 알고리즘 점수 = ", test_score)

ss = StandardScaler()
ss.fit(train_poly)

train_scaled = ss.transform(train_poly)
test_scaled = ss.transform(test_poly)

# print(train_scaled[:5])
# print(test_scaled[:5])

ridge = Ridge()
ridge.fit(train_scaled, train_target)

print(ridge.score(train_scaled, train_target))
print(ridge.score(test_scaled, test_target))

train_score = []
test_score = []

alpha_list = [0.001, 0.01, 0.1, 1, 10, 100]
for alpha in alpha_list:
    ridge = Ridge(alpha=alpha)
    ridge.fit(train_scaled, train_target)
    train_s = ridge.score(train_scaled, train_target)
    test_s = ridge.score(test_scaled, test_target)
    train_score.append(train_s)
    test_score.append(test_s)

plt.plot(np.log10(alpha_list), train_score)
plt.plot(np.log10(alpha_list), test_score)

plt.xlabel('alpha')
plt.ylabel('R^2')
plt.show()

train_score = []
test_score = []
# '순수개발자', '통계학.수학 석사...'
alpha_list = [0.001, 0.01, 0.1, 1, 10, 100]
for alpha in alpha_list:
    lasso = Lasso(alpha=alpha)
    lasso.fit(train_scaled, train_target)
    train_s = lasso.score(train_scaled, train_target)
    test_s = lasso.score(test_scaled, test_target)
    train_score.append(train_s)
    test_score.append(test_s)

plt.plot(np.log10(alpha_list), train_score)
plt.plot(np.log10(alpha_list), test_score)

plt.xlabel('alpha')
plt.ylabel('R^2')
plt.show()

# 토비의 스프링 2권.. 6천페이지..
# 머신러닝 딥러닝 핸즈온 머신러닝... 공식...
