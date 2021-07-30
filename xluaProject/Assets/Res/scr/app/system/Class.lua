-- tsl
-- 2021-7-26
-- class.lua
-- lua 层 创建class
local Class = {}

-- 一个类型默认的属性
local includePropertis = {
	-- new方法
	ctor = function (self, ...) end,
	static = {
		create = function(self)
            assert(type(self) == 'table', "Make sure that you are using 'Class:allocate' instead of 'Class.allocate'")
            return setmetatable({class = self}, self.__instanceDict)
        end,
		-- new方法
		new = function (self, ...)
			local object = self:create()
			object:ctor()
			return object
		end,
	}
}

-- get aClass
local function _getDefaultClass( )
	local aClass = {
		name = name,  -- 类名
		super = super, -- 父类
		static = {},
		superClass = {},
		__instanceDict = {},

	}
	local met = {__index = aClass.static}
	setmetable(aClass, met)

	return classTab
end

-- 对class 初始化
local function _initClass(classTab, includedData)
	assert(type(includedData) == 'table', "includedData must be a table")
    
    for name, method in pairs(includedData) do
        if name ~= "static" then classTab[name] = method end
    end
    
    for name, method in pairs(includedData.static or {}) do
        classTab.static[name] = method
    end
    
    -- if type(includedData.included) == "function" then includedData:included(aClass) end
    return classTab
end


--  创建一个没有继承关系的类
local function _createClass(name)
	local classTab = _getDefaultClass()
	classTab = _initClass(classTab, includePropertis)
	return classTab
end
-- 创建有继承关系的类型
local function _createClassWithSuper(name, super)
	local classTab = _createClass(name)
	classTab.super = require(super)
	return classTab
end

function Class.class(name, super)
	assert(type(name) == 'string', "A name (string) is needed for the new class")
	return super and _createClassWithSuper(name, super) or _createClass(name)
end

setmetable(Class, {__call = function(_, ...) return Class.class(...) end})
return Class