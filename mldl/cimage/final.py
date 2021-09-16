from KNeTest import getresult
from selenium import webdriver
import time

web = webdriver.Chrome()
web.get('http://192.168.0.135:10000')

time.sleep(0.5)
web.find_element_by_xpath('/html/body/div[1]/div/div/blockquote/a').click()

time.sleep(5)
web.quit()

# result = getresult('beforeimages/1.png')
# print(result)
#
# result = getresult('beforeimages/2.png')
# print(result)