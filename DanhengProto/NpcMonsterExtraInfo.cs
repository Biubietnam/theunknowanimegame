using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C33 RID: 3123
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class NpcMonsterExtraInfo : IMessage<NpcMonsterExtraInfo>, IMessage, IEquatable<NpcMonsterExtraInfo>, IDeepCloneable<NpcMonsterExtraInfo>, IBufferMessage
	{
		// Token: 0x170026D5 RID: 9941
		// (get) Token: 0x06008A64 RID: 35428 RVA: 0x0016D6C5 File Offset: 0x0016B8C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<NpcMonsterExtraInfo> Parser
		{
			get
			{
				return NpcMonsterExtraInfo._parser;
			}
		}

		// Token: 0x170026D6 RID: 9942
		// (get) Token: 0x06008A65 RID: 35429 RVA: 0x0016D6CC File Offset: 0x0016B8CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return NpcMonsterExtraInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170026D7 RID: 9943
		// (get) Token: 0x06008A66 RID: 35430 RVA: 0x0016D6DE File Offset: 0x0016B8DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NpcMonsterExtraInfo.Descriptor;
			}
		}

		// Token: 0x06008A67 RID: 35431 RVA: 0x0016D6E5 File Offset: 0x0016B8E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcMonsterExtraInfo()
		{
		}

		// Token: 0x06008A68 RID: 35432 RVA: 0x0016D6ED File Offset: 0x0016B8ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcMonsterExtraInfo(NpcMonsterExtraInfo other) : this()
		{
			this.rogueGameInfo_ = ((other.rogueGameInfo_ != null) ? other.rogueGameInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008A69 RID: 35433 RVA: 0x0016D722 File Offset: 0x0016B922
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcMonsterExtraInfo Clone()
		{
			return new NpcMonsterExtraInfo(this);
		}

		// Token: 0x170026D8 RID: 9944
		// (get) Token: 0x06008A6A RID: 35434 RVA: 0x0016D72A File Offset: 0x0016B92A
		// (set) Token: 0x06008A6B RID: 35435 RVA: 0x0016D732 File Offset: 0x0016B932
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcMonsterRogueInfo RogueGameInfo
		{
			get
			{
				return this.rogueGameInfo_;
			}
			set
			{
				this.rogueGameInfo_ = value;
			}
		}

		// Token: 0x06008A6C RID: 35436 RVA: 0x0016D73B File Offset: 0x0016B93B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NpcMonsterExtraInfo);
		}

		// Token: 0x06008A6D RID: 35437 RVA: 0x0016D749 File Offset: 0x0016B949
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NpcMonsterExtraInfo other)
		{
			return other != null && (other == this || (object.Equals(this.RogueGameInfo, other.RogueGameInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008A6E RID: 35438 RVA: 0x0016D77C File Offset: 0x0016B97C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.rogueGameInfo_ != null)
			{
				num ^= this.RogueGameInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008A6F RID: 35439 RVA: 0x0016D7B8 File Offset: 0x0016B9B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008A70 RID: 35440 RVA: 0x0016D7C0 File Offset: 0x0016B9C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008A71 RID: 35441 RVA: 0x0016D7C9 File Offset: 0x0016B9C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rogueGameInfo_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.RogueGameInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008A72 RID: 35442 RVA: 0x0016D7FC File Offset: 0x0016B9FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.rogueGameInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueGameInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008A73 RID: 35443 RVA: 0x0016D83C File Offset: 0x0016BA3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NpcMonsterExtraInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.rogueGameInfo_ != null)
			{
				if (this.rogueGameInfo_ == null)
				{
					this.RogueGameInfo = new NpcMonsterRogueInfo();
				}
				this.RogueGameInfo.MergeFrom(other.RogueGameInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008A74 RID: 35444 RVA: 0x0016D890 File Offset: 0x0016BA90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008A75 RID: 35445 RVA: 0x0016D89C File Offset: 0x0016BA9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 26U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.rogueGameInfo_ == null)
					{
						this.RogueGameInfo = new NpcMonsterRogueInfo();
					}
					input.ReadMessage(this.RogueGameInfo);
				}
			}
		}

		// Token: 0x04003510 RID: 13584
		private static readonly MessageParser<NpcMonsterExtraInfo> _parser = new MessageParser<NpcMonsterExtraInfo>(() => new NpcMonsterExtraInfo());

		// Token: 0x04003511 RID: 13585
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003512 RID: 13586
		public const int RogueGameInfoFieldNumber = 3;

		// Token: 0x04003513 RID: 13587
		private NpcMonsterRogueInfo rogueGameInfo_;
	}
}
