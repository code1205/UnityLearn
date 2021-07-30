-- tsl
-- 2021-7-30
-- Functions.lua
-- 定义必要方法集合
-- 常量 不允许修改
class = require("Class")

const = function (t)
	local _t = {}
	setmetatable{t, {
		__index = _t,
		__newindex = function (t, key, valua)
			if _t[key] then
				print("不允许修改常量")
			else
				_t[key] = valua
			end
		end
	}}
end