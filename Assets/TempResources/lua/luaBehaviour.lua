
local luaBehaviour = { }
luaBehaviour.__index = luaBehaviour

function luaBehaviour:new(mono)
    local self = {}
    self.Mono = mono 
    self.LuaObj = self
    setmetatable(self, luaBehaviour) 
    return self
end 

function luaBehaviour:Awake ()
    --print("lua luaBehaviour Awake") 
end
function luaBehaviour:OnEnable ()
    --print("lua luaBehaviour OnEnable")  
end
function luaBehaviour:OnApplicationPause (pause)
    --print("lua luaBehaviour OnApplicationPause-> "..tostring(pause))
end
function luaBehaviour:OnApplicationFocus (focus)
    --print("lua luaBehaviour OnApplicationFocus-> "..tostring(focus))
end
function luaBehaviour:Start ()
    --print("lua luaBehaviour Start")  
end
function luaBehaviour:FixedUpdate () 
    --print("lua luaBehaviour FixedUpdate")
end
function luaBehaviour:Update ()   
    --print("lua luaBehaviour Update")
end
function luaBehaviour:LateUpdate () 
    --print("lua luaBehaviour LateUpdate")
end
function luaBehaviour:OnDisable  ()
    --print("lua luaBehaviour OnDisable")
end
function luaBehaviour:OnDestroy ()
    --print("lua luaBehaviour OnDestroy")
end  

if not lua_packages then 
    lua_packages = {}
    lua_packages['luaBehaviour'] = luaBehaviour
end

function treaverse_global_env(curtable,level)
    for key,value in pairs(curtable or {}) do
        local prefix = string.rep(" ",level*5)
        print(string.format("%s%s(%s)",prefix,key,type(value))) 
        --注意死循环
        if (type(value) == "table" ) and key ~= "_G" and (not value.package) then
            treaverse_global_env(value,level + 1)
        elseif (type(value) == "table" ) and (value.package) then
            print(string.format("%sSKIPTABLE:%s",prefix,key))
        end 
    end 
end

--treaverse_global_env(_G,0)

function new_lua_mono(lua,mono)
    if lua_packages[lua] then
        local obj = lua_packages[lua]:new(mono)
        obj.name = lua
        return obj
    end 
    return nil
end

return luaBehaviour