using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000295 RID: 661
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueSelectBpScRsp : IMessage<ChessRogueSelectBpScRsp>, IMessage, IEquatable<ChessRogueSelectBpScRsp>, IDeepCloneable<ChessRogueSelectBpScRsp>, IBufferMessage
	{
		// Token: 0x1700088F RID: 2191
		// (get) Token: 0x06001D72 RID: 7538 RVA: 0x00054603 File Offset: 0x00052803
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueSelectBpScRsp> Parser
		{
			get
			{
				return ChessRogueSelectBpScRsp._parser;
			}
		}

		// Token: 0x17000890 RID: 2192
		// (get) Token: 0x06001D73 RID: 7539 RVA: 0x0005460A File Offset: 0x0005280A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueSelectBpScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000891 RID: 2193
		// (get) Token: 0x06001D74 RID: 7540 RVA: 0x0005461C File Offset: 0x0005281C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueSelectBpScRsp.Descriptor;
			}
		}

		// Token: 0x06001D75 RID: 7541 RVA: 0x00054623 File Offset: 0x00052823
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueSelectBpScRsp()
		{
		}

		// Token: 0x06001D76 RID: 7542 RVA: 0x0005462C File Offset: 0x0005282C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueSelectBpScRsp(ChessRogueSelectBpScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.eAJOBEPJCFK_ = ((other.eAJOBEPJCFK_ != null) ? other.eAJOBEPJCFK_.Clone() : null);
			this.cBKFEHGFCGJ_ = other.cBKFEHGFCGJ_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001D77 RID: 7543 RVA: 0x00054684 File Offset: 0x00052884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueSelectBpScRsp Clone()
		{
			return new ChessRogueSelectBpScRsp(this);
		}

		// Token: 0x17000892 RID: 2194
		// (get) Token: 0x06001D78 RID: 7544 RVA: 0x0005468C File Offset: 0x0005288C
		// (set) Token: 0x06001D79 RID: 7545 RVA: 0x00054694 File Offset: 0x00052894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x17000893 RID: 2195
		// (get) Token: 0x06001D7A RID: 7546 RVA: 0x0005469D File Offset: 0x0005289D
		// (set) Token: 0x06001D7B RID: 7547 RVA: 0x000546A5 File Offset: 0x000528A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DAGLHMKLOGO EAJOBEPJCFK
		{
			get
			{
				return this.eAJOBEPJCFK_;
			}
			set
			{
				this.eAJOBEPJCFK_ = value;
			}
		}

		// Token: 0x17000894 RID: 2196
		// (get) Token: 0x06001D7C RID: 7548 RVA: 0x000546AE File Offset: 0x000528AE
		// (set) Token: 0x06001D7D RID: 7549 RVA: 0x000546B6 File Offset: 0x000528B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CBKFEHGFCGJ
		{
			get
			{
				return this.cBKFEHGFCGJ_;
			}
			set
			{
				this.cBKFEHGFCGJ_ = value;
			}
		}

		// Token: 0x06001D7E RID: 7550 RVA: 0x000546BF File Offset: 0x000528BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueSelectBpScRsp);
		}

		// Token: 0x06001D7F RID: 7551 RVA: 0x000546D0 File Offset: 0x000528D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueSelectBpScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.EAJOBEPJCFK, other.EAJOBEPJCFK) && this.CBKFEHGFCGJ == other.CBKFEHGFCGJ && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001D80 RID: 7552 RVA: 0x00054730 File Offset: 0x00052930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.eAJOBEPJCFK_ != null)
			{
				num ^= this.EAJOBEPJCFK.GetHashCode();
			}
			if (this.CBKFEHGFCGJ != 0U)
			{
				num ^= this.CBKFEHGFCGJ.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001D81 RID: 7553 RVA: 0x0005479E File Offset: 0x0005299E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001D82 RID: 7554 RVA: 0x000547A6 File Offset: 0x000529A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001D83 RID: 7555 RVA: 0x000547B0 File Offset: 0x000529B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Retcode);
			}
			if (this.eAJOBEPJCFK_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.EAJOBEPJCFK);
			}
			if (this.CBKFEHGFCGJ != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.CBKFEHGFCGJ);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001D84 RID: 7556 RVA: 0x00054824 File Offset: 0x00052A24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.eAJOBEPJCFK_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EAJOBEPJCFK);
			}
			if (this.CBKFEHGFCGJ != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CBKFEHGFCGJ);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001D85 RID: 7557 RVA: 0x00054894 File Offset: 0x00052A94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueSelectBpScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.eAJOBEPJCFK_ != null)
			{
				if (this.eAJOBEPJCFK_ == null)
				{
					this.EAJOBEPJCFK = new DAGLHMKLOGO();
				}
				this.EAJOBEPJCFK.MergeFrom(other.EAJOBEPJCFK);
			}
			if (other.CBKFEHGFCGJ != 0U)
			{
				this.CBKFEHGFCGJ = other.CBKFEHGFCGJ;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001D86 RID: 7558 RVA: 0x00054910 File Offset: 0x00052B10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001D87 RID: 7559 RVA: 0x0005491C File Offset: 0x00052B1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 66U)
					{
						if (num != 88U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.CBKFEHGFCGJ = input.ReadUInt32();
						}
					}
					else
					{
						if (this.eAJOBEPJCFK_ == null)
						{
							this.EAJOBEPJCFK = new DAGLHMKLOGO();
						}
						input.ReadMessage(this.EAJOBEPJCFK);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000C49 RID: 3145
		private static readonly MessageParser<ChessRogueSelectBpScRsp> _parser = new MessageParser<ChessRogueSelectBpScRsp>(() => new ChessRogueSelectBpScRsp());

		// Token: 0x04000C4A RID: 3146
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000C4B RID: 3147
		public const int RetcodeFieldNumber = 1;

		// Token: 0x04000C4C RID: 3148
		private uint retcode_;

		// Token: 0x04000C4D RID: 3149
		public const int EAJOBEPJCFKFieldNumber = 8;

		// Token: 0x04000C4E RID: 3150
		private DAGLHMKLOGO eAJOBEPJCFK_;

		// Token: 0x04000C4F RID: 3151
		public const int CBKFEHGFCGJFieldNumber = 11;

		// Token: 0x04000C50 RID: 3152
		private uint cBKFEHGFCGJ_;
	}
}
