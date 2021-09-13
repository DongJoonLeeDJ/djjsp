import numpy as np

onetofive = np.array([1,2,3,4,5])
np.save('a.npy', onetofive)

filetonp = np.load('a.npy')
print(filetonp)