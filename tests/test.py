import unittest
import re

class TestPasswd(unittest.TestCase):
    
    def test_success_passwd(self):
        def_pass = re.compile(r'(?=.*[a-z])(?=.*[A-Z])[a-zA-Z]{5,20}')
        success = ['FffffF', 'FFFFffffF', 'FfFFFFff', 'FFFffffF', 'FaaaaW']
        for item in success:
            self.assertTrue(def_pass.search(item))

    def test_unsuccessful_passwd(self):
        def_pass = re.compile(r'(?=.*[a-z])(?=.*[A-Z])[a-zA-Z]{5,20}')
        unsuccessful = ['cdwa', 'ww1', 'd', '123', '312dwdwddw']
        for item in unsuccessful:
            self.assertFalse(def_pass.search(item))

if __name__ == '__main__':
    unittest.main()