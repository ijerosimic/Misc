<template>
  <ul>
    <li v-for="quote in quotes" :key="quote.id" @click="removeQuote(quote.id)">
      <div>
        <div class="card" style="width: 18rem;">
          <div class="card-body">
            <p class="card-text">{{quote.text}}</p>
          </div>
        </div>
      </div>
    </li>
  </ul>
</template>

<script>
import { quoteAdderBus } from "../main.js";
import { quoteRemoverBus } from "../main.js";

export default {
  data: function() {
    return {
      quotes: [],
      id: 0
    };
  },
  created() {
    quoteAdderBus.$on("quoteWasAdded", quote => {
      this.id++;
      let q = {
        id: this.id,
        text: quote
      };
      this.quotes.push(q);
    });
  },
  methods: {
    removeQuote(id) {
      let index = this.quotes.findIndex(q => q.id == id);
      this.quotes.splice(index, 1);
      
      quoteRemoverBus.$emit('quoteWasRemoved');
    }
  }
};
</script>

<style>
ul {
  list-style-type: none;
  margin: 0;
  padding: 0;
  overflow: hidden;
}

li {
  float: left;
}

li a {
  display: block;
  color: white;
  text-align: center;
  padding: 16px;
  text-decoration: none;
}

li a:hover {
  background-color: #111111;
}
</style>


