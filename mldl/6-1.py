from ctypes import c_char

import numpy as np
import matplotlib.pyplot as plt

fruits = np.load('fruits_300.npy')
print(fruits.shape)

print(fruits[0, :, :])

# fig,axis = plt.subplots(1,2)
# axis[0].imshow(fruits[100],cmap='gray_r')
# axis[1].imshow(fruits[200],cmap='gray_r')

apple = fruits[:100]
print(apple.shape)
apple = fruits[:100].reshape(-1, 100 * 100)
print(apple.shape)

pineapple = fruits[100:200]
print(pineapple.shape)
pineapple = fruits[100:200].reshape(-1, 100 * 100)
print(pineapple.shape)

banana = fruits[200:300]
print(banana.shape)
banana = fruits[200:300].reshape(-1, 100 * 100)
print(banana.shape)

# fig, axs = plt.subplots(1, 3, figsize=(20, 5))
# plt.hist(np.mean(apple, axis=1), alpha=0.8)
# plt.hist(np.mean(pineapple, axis=1), alpha=0.8)
# plt.hist(np.mean(banana, axis=1), alpha=0.8)
# plt.legend(['apple', 'pineapple', 'banana'])
# plt.show()
#
# fig, axs = plt.subplots(1, 3, figsize=(20, 5))
# axs[0].bar(range(10000), np.mean(apple, axis=0))
# axs[1].bar(range(10000), np.mean(pineapple, axis=0))
# axs[2].bar(range(10000), np.mean(banana, axis=0))
# plt.show()

apple_mean = np.mean(apple, axis=0).reshape(100, 100)
pineapple_mean = np.mean(pineapple, axis=0).reshape(100, 100)
banana_mean = np.mean(banana, axis=0).reshape(100, 100)

abs_diff = np.abs(fruits - apple_mean)
print(abs_diff)
abs_mean = np.mean(abs_diff, axis=(1,2))
print(abs_mean)
print(abs_mean.shape)

apple_index = np.argsort(abs_mean)[:100]
print(apple_index)
fig, axs = plt.subplots(10, 10, figsize=(10,10), dpi=50)
for i in range(10):
    for j in range(10):
        axs[i, j].imshow(fruits[apple_index[i*10 + j]], cmap='gray_r')
        axs[i, j].axis('off')
plt.show()

abs_diff = np.abs(fruits - banana_mean)
abs_mean = np.mean(abs_diff, axis=(1,2))
print(abs_mean.shape)

banana_index = np.argsort(abs_mean)[:100]
fig, axs = plt.subplots(10, 10, figsize=(10,10), dpi=50)
for i in range(10):
    for j in range(10):
        axs[i, j].imshow(fruits[banana_index[i*10 + j]], cmap='gray_r')
        axs[i, j].axis('off')
plt.show()

abs_diff = np.abs(fruits - pineapple_mean)
abs_mean = np.mean(abs_diff, axis=(1,2))
print(abs_mean.shape)

pineapple_index = np.argsort(abs_mean)[:100]
fig, axs = plt.subplots(10, 10, figsize=(10,10), dpi=50)
for i in range(10):
    for j in range(10):
        axs[i, j].imshow(fruits[pineapple_index[i*10 + j]], cmap='gray_r')
        axs[i, j].axis('off')
plt.show()