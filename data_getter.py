import sys
import clr
import json
from io import open

sys.path.append('C:\Users\liff\Documents\ASMRProject')

clr.AddReferenceToFile('GraphicsCard.dll')
from GraphicsCards import GraphicsCard

if __name__ == '__main__':
    with open('graphics_card_info.json','r',encoding='utf-8-sig') as file:
        graphics_card_data = json.load(file)

    keys = graphics_card_data.keys()

    graphics_card_list = list()

    for key in keys:
        current_card = graphics_card_data[key]
        graphics_card_list.append(
            GraphicsCard(current_card['name'],
                         current_card['rating'],
                         current_card['review_date'],
                         current_card['interface'],
                         current_card['ram'],
                         current_card['ram_type'],
                         current_card['clock_speed'],
                         current_card['cost_usd'],
                         current_card['cost_gbp'],
                         current_card['amazon_link']))

    for card in graphics_card_list:
        print card
        print