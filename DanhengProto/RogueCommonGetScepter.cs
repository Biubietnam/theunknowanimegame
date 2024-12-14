using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E55 RID: 3669
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueCommonGetScepter : IMessage<RogueCommonGetScepter>, IMessage, IEquatable<RogueCommonGetScepter>, IDeepCloneable<RogueCommonGetScepter>, IBufferMessage
	{
		// Token: 0x17002E38 RID: 11832
		// (get) Token: 0x0600A3AC RID: 41900 RVA: 0x001B8433 File Offset: 0x001B6633
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueCommonGetScepter> Parser
		{
			get
			{
				return RogueCommonGetScepter._parser;
			}
		}

		// Token: 0x17002E39 RID: 11833
		// (get) Token: 0x0600A3AD RID: 41901 RVA: 0x001B843A File Offset: 0x001B663A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueCommonGetScepterReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002E3A RID: 11834
		// (get) Token: 0x0600A3AE RID: 41902 RVA: 0x001B844C File Offset: 0x001B664C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueCommonGetScepter.Descriptor;
			}
		}

		// Token: 0x0600A3AF RID: 41903 RVA: 0x001B8453 File Offset: 0x001B6653
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonGetScepter()
		{
		}

		// Token: 0x0600A3B0 RID: 41904 RVA: 0x001B845B File Offset: 0x001B665B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonGetScepter(RogueCommonGetScepter other) : this()
		{
			this.updateScepterInfo_ = ((other.updateScepterInfo_ != null) ? other.updateScepterInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A3B1 RID: 41905 RVA: 0x001B8490 File Offset: 0x001B6690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonGetScepter Clone()
		{
			return new RogueCommonGetScepter(this);
		}

		// Token: 0x17002E3B RID: 11835
		// (get) Token: 0x0600A3B2 RID: 41906 RVA: 0x001B8498 File Offset: 0x001B6698
		// (set) Token: 0x0600A3B3 RID: 41907 RVA: 0x001B84A0 File Offset: 0x001B66A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicGameScepterInfo UpdateScepterInfo
		{
			get
			{
				return this.updateScepterInfo_;
			}
			set
			{
				this.updateScepterInfo_ = value;
			}
		}

		// Token: 0x0600A3B4 RID: 41908 RVA: 0x001B84A9 File Offset: 0x001B66A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueCommonGetScepter);
		}

		// Token: 0x0600A3B5 RID: 41909 RVA: 0x001B84B7 File Offset: 0x001B66B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueCommonGetScepter other)
		{
			return other != null && (other == this || (object.Equals(this.UpdateScepterInfo, other.UpdateScepterInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A3B6 RID: 41910 RVA: 0x001B84EC File Offset: 0x001B66EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.updateScepterInfo_ != null)
			{
				num ^= this.UpdateScepterInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A3B7 RID: 41911 RVA: 0x001B8528 File Offset: 0x001B6728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A3B8 RID: 41912 RVA: 0x001B8530 File Offset: 0x001B6730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A3B9 RID: 41913 RVA: 0x001B8539 File Offset: 0x001B6739
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.updateScepterInfo_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.UpdateScepterInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A3BA RID: 41914 RVA: 0x001B856C File Offset: 0x001B676C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.updateScepterInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.UpdateScepterInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A3BB RID: 41915 RVA: 0x001B85AC File Offset: 0x001B67AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueCommonGetScepter other)
		{
			if (other == null)
			{
				return;
			}
			if (other.updateScepterInfo_ != null)
			{
				if (this.updateScepterInfo_ == null)
				{
					this.UpdateScepterInfo = new RogueMagicGameScepterInfo();
				}
				this.UpdateScepterInfo.MergeFrom(other.UpdateScepterInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A3BC RID: 41916 RVA: 0x001B8600 File Offset: 0x001B6800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A3BD RID: 41917 RVA: 0x001B860C File Offset: 0x001B680C
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
					if (this.updateScepterInfo_ == null)
					{
						this.UpdateScepterInfo = new RogueMagicGameScepterInfo();
					}
					input.ReadMessage(this.UpdateScepterInfo);
				}
			}
		}

		// Token: 0x040042FE RID: 17150
		private static readonly MessageParser<RogueCommonGetScepter> _parser = new MessageParser<RogueCommonGetScepter>(() => new RogueCommonGetScepter());

		// Token: 0x040042FF RID: 17151
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004300 RID: 17152
		public const int UpdateScepterInfoFieldNumber = 8;

		// Token: 0x04004301 RID: 17153
		private RogueMagicGameScepterInfo updateScepterInfo_;
	}
}
