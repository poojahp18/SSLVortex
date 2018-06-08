--By DATE
SELECT S1.SessionID,ReqLines,ReqHLines,ReqBody,ResLines,ResHLines,ResBody
FROM SessionDB S1,StorageDB S2 
WHERE S1.SessionID = S2.SessionID
	AND s1.StartTS >= '06-07-2018'
	AND s1.EndTS < '07-07-2018'

--By Month
SELECT S1.SessionID,ReqLines,ReqHLines,ReqBody,ResLines,ResHLines,ResBody
FROM SessionDB S1,StorageDB S2 
WHERE S1.SessionID = S2.SessionID
	AND s1.StartTS >= 'june 2018'
	AND s1.EndTS < 'july 2018'

--By Year
SELECT S1.SessionID,ReqLines,ReqHLines,ReqBody,ResLines,ResHLines,ResBody
FROM SessionDB S1,StorageDB S2 
WHERE S1.SessionID = S2.SessionID
	AND s1.StartTS >= '2018'
	AND s1.EndTS < '2019'

--By Website
SELECT S1.SessionID,ReqLines,ReqHLines,ReqBody,ResLines,ResHLines,ResBody
FROM SessionDB S1,StorageDB S2 
WHERE S1.SessionID = S2.SessionID
	 AND S2.ReqLines LIKE '%localhost%'

--By Session ID
SELECT S1.SessionID,ReqLines,ReqHLines,ReqBody,ResLines,ResHLines,ResBody
FROM SessionDB S1,StorageDB S2 
WHERE S1.SessionID = S2.SessionID
	AND S1.SessionID = 15
	