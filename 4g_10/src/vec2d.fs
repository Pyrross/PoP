module vec2d
let len ((x1, y1) : float * float) : float = (x1*x1 + y1*y1) ** 0.5
let ang ((x1, y1) : float * float) : float = atan (y1 / x1)
let scale (c : float) ((x1, y1) : float * float) : float * float = (c * x1, c * y1)
let add ((x1, y1) : float * float) ((x2, y2) : float * float) : float * float = (x1 + x2, y1 + y2)
let dot ((x1, y1) : float * float) ((x2, y2) : float * float) : float = x1 * y1 + x2 * y2
