local lua = "local lua = %s local py = %s local q = string.char(34) print(string.format(py, q .. py .. q, q .. lua .. q))"
local py = "py = %s; lua = %s; q = chr(34); print(lua %% (q + lua + q, q + py + q))"
local q = string.char(34)
print(string.format(py, q .. py .. q, q .. lua .. q))