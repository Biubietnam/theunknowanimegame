using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200100D RID: 4109
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournReviveCostUpdateScNotify : IMessage<RogueTournReviveCostUpdateScNotify>, IMessage, IEquatable<RogueTournReviveCostUpdateScNotify>, IDeepCloneable<RogueTournReviveCostUpdateScNotify>, IBufferMessage
	{
		// Token: 0x17003380 RID: 13184
		// (get) Token: 0x0600B6D1 RID: 46801 RVA: 0x001EA6B7 File Offset: 0x001E88B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournReviveCostUpdateScNotify> Parser
		{
			get
			{
				return RogueTournReviveCostUpdateScNotify._parser;
			}
		}

		// Token: 0x17003381 RID: 13185
		// (get) Token: 0x0600B6D2 RID: 46802 RVA: 0x001EA6BE File Offset: 0x001E88BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournReviveCostUpdateScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003382 RID: 13186
		// (get) Token: 0x0600B6D3 RID: 46803 RVA: 0x001EA6D0 File Offset: 0x001E88D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournReviveCostUpdateScNotify.Descriptor;
			}
		}

		// Token: 0x0600B6D4 RID: 46804 RVA: 0x001EA6D7 File Offset: 0x001E88D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournReviveCostUpdateScNotify()
		{
		}

		// Token: 0x0600B6D5 RID: 46805 RVA: 0x001EA6DF File Offset: 0x001E88DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournReviveCostUpdateScNotify(RogueTournReviveCostUpdateScNotify other) : this()
		{
			this.rogueReviveCost_ = ((other.rogueReviveCost_ != null) ? other.rogueReviveCost_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B6D6 RID: 46806 RVA: 0x001EA714 File Offset: 0x001E8914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournReviveCostUpdateScNotify Clone()
		{
			return new RogueTournReviveCostUpdateScNotify(this);
		}

		// Token: 0x17003383 RID: 13187
		// (get) Token: 0x0600B6D7 RID: 46807 RVA: 0x001EA71C File Offset: 0x001E891C
		// (set) Token: 0x0600B6D8 RID: 46808 RVA: 0x001EA724 File Offset: 0x001E8924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemCostData RogueReviveCost
		{
			get
			{
				return this.rogueReviveCost_;
			}
			set
			{
				this.rogueReviveCost_ = value;
			}
		}

		// Token: 0x0600B6D9 RID: 46809 RVA: 0x001EA72D File Offset: 0x001E892D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournReviveCostUpdateScNotify);
		}

		// Token: 0x0600B6DA RID: 46810 RVA: 0x001EA73B File Offset: 0x001E893B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournReviveCostUpdateScNotify other)
		{
			return other != null && (other == this || (object.Equals(this.RogueReviveCost, other.RogueReviveCost) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B6DB RID: 46811 RVA: 0x001EA770 File Offset: 0x001E8970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.rogueReviveCost_ != null)
			{
				num ^= this.RogueReviveCost.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B6DC RID: 46812 RVA: 0x001EA7AC File Offset: 0x001E89AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B6DD RID: 46813 RVA: 0x001EA7B4 File Offset: 0x001E89B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B6DE RID: 46814 RVA: 0x001EA7BD File Offset: 0x001E89BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rogueReviveCost_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.RogueReviveCost);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B6DF RID: 46815 RVA: 0x001EA7F0 File Offset: 0x001E89F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.rogueReviveCost_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueReviveCost);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B6E0 RID: 46816 RVA: 0x001EA830 File Offset: 0x001E8A30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournReviveCostUpdateScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.rogueReviveCost_ != null)
			{
				if (this.rogueReviveCost_ == null)
				{
					this.RogueReviveCost = new ItemCostData();
				}
				this.RogueReviveCost.MergeFrom(other.RogueReviveCost);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B6E1 RID: 46817 RVA: 0x001EA884 File Offset: 0x001E8A84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B6E2 RID: 46818 RVA: 0x001EA890 File Offset: 0x001E8A90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 66U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.rogueReviveCost_ == null)
					{
						this.RogueReviveCost = new ItemCostData();
					}
					input.ReadMessage(this.RogueReviveCost);
				}
			}
		}

		// Token: 0x04004A0B RID: 18955
		private static readonly MessageParser<RogueTournReviveCostUpdateScNotify> _parser = new MessageParser<RogueTournReviveCostUpdateScNotify>(() => new RogueTournReviveCostUpdateScNotify());

		// Token: 0x04004A0C RID: 18956
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A0D RID: 18957
		public const int RogueReviveCostFieldNumber = 8;

		// Token: 0x04004A0E RID: 18958
		private ItemCostData rogueReviveCost_;
	}
}
