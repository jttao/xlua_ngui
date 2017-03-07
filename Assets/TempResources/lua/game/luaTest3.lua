local luaBehaviour = require('../luaBehaviour')

local luaTest3 = {}

setmetatable(luaTest3, luaBehaviour) 

luaTest3.__index = luaTest3

function luaTest3:new(mono)
    local self = luaBehaviour:new(mono) 
    setmetatable(self, luaTest3) 
    return self  
end 

function luaTest3:Start ()   
    
    local label = self.Mono.transform:FindChild ("Label"):GetComponent(typeof(CS.UILabel)) 
    label.text = "WWW UI"
    
    local button = self.Mono.transform:FindChild ("Button"):GetComponent(typeof(CS.UIButton)) 
    button.onClick:Add (CS.EventDelegate ( function  () 
        CS.UnityEngine.GameObject.Destroy(self.Mono.gameObject)
    end ));  
    
    self.Mono.gameObject:AddComponent(typeof(CS.HotfixTest))    

end 

lua_packages['luaTest3'] = luaTest3

return luaTest3