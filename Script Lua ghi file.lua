local file = io.open("data.txt","r")

if file then
    local content = file:read("*all")
    print(content)
    file:close()
else
    print("Không tìm thấy file")
end

