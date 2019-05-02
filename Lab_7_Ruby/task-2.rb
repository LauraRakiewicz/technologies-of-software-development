#1 
numbers = 1,2,3,4,5
numbers.sort! {|a, b| a <=> b}

min_sum = 0
max_sum = 0
for i in (0...(numbers.length - 1)) do
  min_sum += numbers[i]
  max_sum += numbers[i + 1]
end
puts "Task 1:"
puts min_sum.to_s + " " + max_sum.to_s
puts " "

#2
module Leap
  def leapYear
    if self%4 == 0 && (self%100 != 0 || self%400 == 0)
      puts "#{self} is a leap year"
    else puts  "#{self} isn't a leap year"
    end
  end
end
Integer.include(Leap)

puts "Task 2:"
1996.leapYear
1997.leapYear
puts " "

#3
def to_decimal(num, i=0)
  product      = num % 10 * 2**i
  return product if num < 1
  product + to_decimal(num/10, i+1)
end

puts "Task 3:"
puts to_decimal(101)
puts " "

#4
def word_count(line)
  h = Hash.new
  words = line.split
  words.each { |w|
    if h.has_key?(w)
      h[w] = h[w] + 1
    else
      h[w] = 1
    end
  }

  h.sort{|a,b| a[1]<=>b[1]}.each { |elem|
    puts "\"#{elem[0]}\": #{elem[1]}"}
end

puts "Task 4:"
line = "olly olly in come free"
word_count(line)
puts " "

#5
def is_pangram(line)
  ('a'..'z').all? { |word| line.downcase.include? (word) }
end

line = "The quick brown fox jumps over the lazy dog"

puts "Task 5:"
if is_pangram(line) then 
  puts "The sentence IS a pangram"
else
  puts "The sentence IS NOT a pangram"
end

