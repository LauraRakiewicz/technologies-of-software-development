#1
def generate(n)
  return [] if n == 1
  factor = (2..n).find {|x| n % x == 0} 
  [factor] + generate(n / factor) 
end
puts "Task 1"
puts generate(60).sort { |x,y| y <=> x }
puts " "

#2'
def multiples(num, a, b)
  puts "sum: " 
  puts get_sum(num,a) 
  puts "sum: " 
  puts get_sum(num,b)
  
end

def multiplesSum(number, arg1, arg2)
  (1..number-1).select {|n| n%arg1==0 || n%arg2==0}.inject(0) {|s,n| s+=n}
end

puts "Task 2"
puts multiplesSum(20, 3, 5)
puts " "

#3
def checkNumber(n)
  if (n.length < 10) || (n.length > 11)
    puts 'bad number'
  else if n.length == 11
         if n[0] == '1'
           puts 'ok ' + n
         else
           puts 'bad number'
         end
       else
         puts 'ok'
  end
  end
end
puts "Task 3"
puts checkNumber('123456789')