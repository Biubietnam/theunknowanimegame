using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000403 RID: 1027
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EIGCJPGPIOC : IMessage<EIGCJPGPIOC>, IMessage, IEquatable<EIGCJPGPIOC>, IDeepCloneable<EIGCJPGPIOC>, IBufferMessage
	{
		// Token: 0x17000D0E RID: 3342
		// (get) Token: 0x06002D91 RID: 11665 RVA: 0x0007E1A7 File Offset: 0x0007C3A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EIGCJPGPIOC> Parser
		{
			get
			{
				return EIGCJPGPIOC._parser;
			}
		}

		// Token: 0x17000D0F RID: 3343
		// (get) Token: 0x06002D92 RID: 11666 RVA: 0x0007E1AE File Offset: 0x0007C3AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EIGCJPGPIOCReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000D10 RID: 3344
		// (get) Token: 0x06002D93 RID: 11667 RVA: 0x0007E1C0 File Offset: 0x0007C3C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EIGCJPGPIOC.Descriptor;
			}
		}

		// Token: 0x06002D94 RID: 11668 RVA: 0x0007E1C7 File Offset: 0x0007C3C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EIGCJPGPIOC()
		{
		}

		// Token: 0x06002D95 RID: 11669 RVA: 0x0007E1D0 File Offset: 0x0007C3D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EIGCJPGPIOC(EIGCJPGPIOC other) : this()
		{
			this.rogueAreaInfo_ = ((other.rogueAreaInfo_ != null) ? other.rogueAreaInfo_.Clone() : null);
			this.oJFJFEJMJPG_ = ((other.oJFJFEJMJPG_ != null) ? other.oJFJFEJMJPG_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002D96 RID: 11670 RVA: 0x0007E22C File Offset: 0x0007C42C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EIGCJPGPIOC Clone()
		{
			return new EIGCJPGPIOC(this);
		}

		// Token: 0x17000D11 RID: 3345
		// (get) Token: 0x06002D97 RID: 11671 RVA: 0x0007E234 File Offset: 0x0007C434
		// (set) Token: 0x06002D98 RID: 11672 RVA: 0x0007E23C File Offset: 0x0007C43C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LMPOJGEHFIP RogueAreaInfo
		{
			get
			{
				return this.rogueAreaInfo_;
			}
			set
			{
				this.rogueAreaInfo_ = value;
			}
		}

		// Token: 0x17000D12 RID: 3346
		// (get) Token: 0x06002D99 RID: 11673 RVA: 0x0007E245 File Offset: 0x0007C445
		// (set) Token: 0x06002D9A RID: 11674 RVA: 0x0007E24D File Offset: 0x0007C44D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KIANELPLCMF OJFJFEJMJPG
		{
			get
			{
				return this.oJFJFEJMJPG_;
			}
			set
			{
				this.oJFJFEJMJPG_ = value;
			}
		}

		// Token: 0x06002D9B RID: 11675 RVA: 0x0007E256 File Offset: 0x0007C456
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EIGCJPGPIOC);
		}

		// Token: 0x06002D9C RID: 11676 RVA: 0x0007E264 File Offset: 0x0007C464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EIGCJPGPIOC other)
		{
			return other != null && (other == this || (object.Equals(this.RogueAreaInfo, other.RogueAreaInfo) && object.Equals(this.OJFJFEJMJPG, other.OJFJFEJMJPG) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002D9D RID: 11677 RVA: 0x0007E2B8 File Offset: 0x0007C4B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.rogueAreaInfo_ != null)
			{
				num ^= this.RogueAreaInfo.GetHashCode();
			}
			if (this.oJFJFEJMJPG_ != null)
			{
				num ^= this.OJFJFEJMJPG.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002D9E RID: 11678 RVA: 0x0007E30A File Offset: 0x0007C50A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002D9F RID: 11679 RVA: 0x0007E312 File Offset: 0x0007C512
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002DA0 RID: 11680 RVA: 0x0007E31C File Offset: 0x0007C51C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rogueAreaInfo_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.RogueAreaInfo);
			}
			if (this.oJFJFEJMJPG_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.OJFJFEJMJPG);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002DA1 RID: 11681 RVA: 0x0007E378 File Offset: 0x0007C578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.rogueAreaInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueAreaInfo);
			}
			if (this.oJFJFEJMJPG_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.OJFJFEJMJPG);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002DA2 RID: 11682 RVA: 0x0007E3D0 File Offset: 0x0007C5D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EIGCJPGPIOC other)
		{
			if (other == null)
			{
				return;
			}
			if (other.rogueAreaInfo_ != null)
			{
				if (this.rogueAreaInfo_ == null)
				{
					this.RogueAreaInfo = new LMPOJGEHFIP();
				}
				this.RogueAreaInfo.MergeFrom(other.RogueAreaInfo);
			}
			if (other.oJFJFEJMJPG_ != null)
			{
				if (this.oJFJFEJMJPG_ == null)
				{
					this.OJFJFEJMJPG = new KIANELPLCMF();
				}
				this.OJFJFEJMJPG.MergeFrom(other.OJFJFEJMJPG);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002DA3 RID: 11683 RVA: 0x0007E450 File Offset: 0x0007C650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002DA4 RID: 11684 RVA: 0x0007E45C File Offset: 0x0007C65C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 66U)
				{
					if (num != 90U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.oJFJFEJMJPG_ == null)
						{
							this.OJFJFEJMJPG = new KIANELPLCMF();
						}
						input.ReadMessage(this.OJFJFEJMJPG);
					}
				}
				else
				{
					if (this.rogueAreaInfo_ == null)
					{
						this.RogueAreaInfo = new LMPOJGEHFIP();
					}
					input.ReadMessage(this.RogueAreaInfo);
				}
			}
		}

		// Token: 0x0400125A RID: 4698
		private static readonly MessageParser<EIGCJPGPIOC> _parser = new MessageParser<EIGCJPGPIOC>(() => new EIGCJPGPIOC());

		// Token: 0x0400125B RID: 4699
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400125C RID: 4700
		public const int RogueAreaInfoFieldNumber = 8;

		// Token: 0x0400125D RID: 4701
		private LMPOJGEHFIP rogueAreaInfo_;

		// Token: 0x0400125E RID: 4702
		public const int OJFJFEJMJPGFieldNumber = 11;

		// Token: 0x0400125F RID: 4703
		private KIANELPLCMF oJFJFEJMJPG_;
	}
}
