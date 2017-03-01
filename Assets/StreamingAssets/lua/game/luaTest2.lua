local luaBehaviour = require('../luaBehaviour')

local luaTest2 = {}

setmetatable(luaTest2, luaBehaviour) 

luaTest2.__index = luaTest2

function luaTest2:new(mono)
    local self = luaBehaviour:new(mono) 
    setmetatable(self, luaTest2) 
    return self  
end 

function luaTest2:Start () 
    self:A()  
    local label = self.Mono.transform:FindChild ("Label"):GetComponent(typeof(CS.UILabel)) 
    label.text = "Resources UI"
    label.fontSize = 28
    label.width = 120
    
    local button = self.Mono.transform:FindChild ("Button"):GetComponent(typeof(CS.UIButton)) 
    button.onClick:Add (CS.EventDelegate ( function  () 
        CS.UnityEngine.GameObject.Destroy(self.Mono.gameObject)
    end ));  
end 

function luaTest2:A () 
    print("A");
end

lua_packages['luaTest2'] = luaTest2

return luaTest2
