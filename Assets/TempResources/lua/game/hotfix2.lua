print("hello hotfix2")

local util = require 'xlua.util'

xlua.hotfix(CS.HotfixTest,{
        Awake = function(self)
            print("LUA Awake.")
        end,
        Start = function(self)
            print("LUA Start.")
            self:DoCoroutine(5)
            self:DoCoroutine0() 
        end,
        MyCoroutine = function(self,prame)
            return util.cs_generator(function()
                coroutine.yield(CS.UnityEngine.WaitForSeconds(prame))
                print('LUA MyCoroutine WaitForSeconds '..prame..'s.')          
            end)
        end,
        DoCoroutine = function(self,prame) 
            print("LUA DoCoroutine."..prame)  
            self:StartCoroutine(self:MyCoroutine(prame))  
        end,
        MyCoroutine0 = function(self)
            return util.cs_generator(function()
                coroutine.yield(CS.UnityEngine.WaitForEndOfFrame())
                print('LUA MyCoroutine0.')          
            end)
        end,
        DoCoroutine0 = function(self) 
            print("LUA DoCoroutine0.")  
            self:StartCoroutine("MyCoroutine0") 
        end 
}) 