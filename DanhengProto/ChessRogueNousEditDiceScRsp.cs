using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000253 RID: 595
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueNousEditDiceScRsp : IMessage<ChessRogueNousEditDiceScRsp>, IMessage, IEquatable<ChessRogueNousEditDiceScRsp>, IDeepCloneable<ChessRogueNousEditDiceScRsp>, IBufferMessage
	{
		// Token: 0x170007CE RID: 1998
		// (get) Token: 0x06001AA6 RID: 6822 RVA: 0x0004D397 File Offset: 0x0004B597
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueNousEditDiceScRsp> Parser
		{
			get
			{
				return ChessRogueNousEditDiceScRsp._parser;
			}
		}

		// Token: 0x170007CF RID: 1999
		// (get) Token: 0x06001AA7 RID: 6823 RVA: 0x0004D39E File Offset: 0x0004B59E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueNousEditDiceScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170007D0 RID: 2000
		// (get) Token: 0x06001AA8 RID: 6824 RVA: 0x0004D3B0 File Offset: 0x0004B5B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueNousEditDiceScRsp.Descriptor;
			}
		}

		// Token: 0x06001AA9 RID: 6825 RVA: 0x0004D3B7 File Offset: 0x0004B5B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueNousEditDiceScRsp()
		{
		}

		// Token: 0x06001AAA RID: 6826 RVA: 0x0004D3C0 File Offset: 0x0004B5C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueNousEditDiceScRsp(ChessRogueNousEditDiceScRsp other) : this()
		{
			this.queryDiceInfo_ = ((other.queryDiceInfo_ != null) ? other.queryDiceInfo_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001AAB RID: 6827 RVA: 0x0004D40C File Offset: 0x0004B60C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueNousEditDiceScRsp Clone()
		{
			return new ChessRogueNousEditDiceScRsp(this);
		}

		// Token: 0x170007D1 RID: 2001
		// (get) Token: 0x06001AAC RID: 6828 RVA: 0x0004D414 File Offset: 0x0004B614
		// (set) Token: 0x06001AAD RID: 6829 RVA: 0x0004D41C File Offset: 0x0004B61C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueDice QueryDiceInfo
		{
			get
			{
				return this.queryDiceInfo_;
			}
			set
			{
				this.queryDiceInfo_ = value;
			}
		}

		// Token: 0x170007D2 RID: 2002
		// (get) Token: 0x06001AAE RID: 6830 RVA: 0x0004D425 File Offset: 0x0004B625
		// (set) Token: 0x06001AAF RID: 6831 RVA: 0x0004D42D File Offset: 0x0004B62D
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

		// Token: 0x06001AB0 RID: 6832 RVA: 0x0004D436 File Offset: 0x0004B636
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueNousEditDiceScRsp);
		}

		// Token: 0x06001AB1 RID: 6833 RVA: 0x0004D444 File Offset: 0x0004B644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueNousEditDiceScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.QueryDiceInfo, other.QueryDiceInfo) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001AB2 RID: 6834 RVA: 0x0004D494 File Offset: 0x0004B694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.queryDiceInfo_ != null)
			{
				num ^= this.QueryDiceInfo.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001AB3 RID: 6835 RVA: 0x0004D4E9 File Offset: 0x0004B6E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001AB4 RID: 6836 RVA: 0x0004D4F1 File Offset: 0x0004B6F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001AB5 RID: 6837 RVA: 0x0004D4FC File Offset: 0x0004B6FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.queryDiceInfo_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.QueryDiceInfo);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001AB6 RID: 6838 RVA: 0x0004D558 File Offset: 0x0004B758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.queryDiceInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.QueryDiceInfo);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001AB7 RID: 6839 RVA: 0x0004D5B0 File Offset: 0x0004B7B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueNousEditDiceScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.queryDiceInfo_ != null)
			{
				if (this.queryDiceInfo_ == null)
				{
					this.QueryDiceInfo = new ChessRogueDice();
				}
				this.QueryDiceInfo.MergeFrom(other.QueryDiceInfo);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001AB8 RID: 6840 RVA: 0x0004D618 File Offset: 0x0004B818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001AB9 RID: 6841 RVA: 0x0004D624 File Offset: 0x0004B824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 34U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					if (this.queryDiceInfo_ == null)
					{
						this.QueryDiceInfo = new ChessRogueDice();
					}
					input.ReadMessage(this.QueryDiceInfo);
				}
			}
		}

		// Token: 0x04000B4D RID: 2893
		private static readonly MessageParser<ChessRogueNousEditDiceScRsp> _parser = new MessageParser<ChessRogueNousEditDiceScRsp>(() => new ChessRogueNousEditDiceScRsp());

		// Token: 0x04000B4E RID: 2894
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000B4F RID: 2895
		public const int QueryDiceInfoFieldNumber = 4;

		// Token: 0x04000B50 RID: 2896
		private ChessRogueDice queryDiceInfo_;

		// Token: 0x04000B51 RID: 2897
		public const int RetcodeFieldNumber = 11;

		// Token: 0x04000B52 RID: 2898
		private uint retcode_;
	}
}
