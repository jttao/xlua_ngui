local luaBehaviour = require('../luaBehaviour')

local luaTest4 = {}

setmetatable(luaTest4, luaBehaviour) 

luaTest4.__index = luaTest4

function luaTest4:new(mono)
    local self = luaBehaviour:new(mono) 
    setmetatable(self, luaTest4) 
    return self  
end 

function luaTest4:Start ()   
    
    self.Mono.LuaObj:B()

	local lua1 = self.Mono:GetLuaObj("luaTest1")
    
    print(lua1.name)

    lua1:A()

    
end 

function luaTest4:B()
    print("C# LUA B->"..self.Mono.LuaObj.name)
end 

lua_packages['luaTest4'] = luaTest4

return luaTest4