using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000421 RID: 1057
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EnhanceChessRogueBuffScRsp : IMessage<EnhanceChessRogueBuffScRsp>, IMessage, IEquatable<EnhanceChessRogueBuffScRsp>, IDeepCloneable<EnhanceChessRogueBuffScRsp>, IBufferMessage
	{
		// Token: 0x17000D6F RID: 3439
		// (get) Token: 0x06002EF5 RID: 12021 RVA: 0x00081AD3 File Offset: 0x0007FCD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EnhanceChessRogueBuffScRsp> Parser
		{
			get
			{
				return EnhanceChessRogueBuffScRsp._parser;
			}
		}

		// Token: 0x17000D70 RID: 3440
		// (get) Token: 0x06002EF6 RID: 12022 RVA: 0x00081ADA File Offset: 0x0007FCDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EnhanceChessRogueBuffScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000D71 RID: 3441
		// (get) Token: 0x06002EF7 RID: 12023 RVA: 0x00081AEC File Offset: 0x0007FCEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnhanceChessRogueBuffScRsp.Descriptor;
			}
		}

		// Token: 0x06002EF8 RID: 12024 RVA: 0x00081AF3 File Offset: 0x0007FCF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnhanceChessRogueBuffScRsp()
		{
		}

		// Token: 0x06002EF9 RID: 12025 RVA: 0x00081AFC File Offset: 0x0007FCFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnhanceChessRogueBuffScRsp(EnhanceChessRogueBuffScRsp other) : this()
		{
			this.rogueBuff_ = ((other.rogueBuff_ != null) ? other.rogueBuff_.Clone() : null);
			this.buffEnhanceInfo_ = ((other.buffEnhanceInfo_ != null) ? other.buffEnhanceInfo_.Clone() : null);
			this.retcode_ = other.retcode_;
			this.isSuccess_ = other.isSuccess_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002EFA RID: 12026 RVA: 0x00081B70 File Offset: 0x0007FD70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnhanceChessRogueBuffScRsp Clone()
		{
			return new EnhanceChessRogueBuffScRsp(this);
		}

		// Token: 0x17000D72 RID: 3442
		// (get) Token: 0x06002EFB RID: 12027 RVA: 0x00081B78 File Offset: 0x0007FD78
		// (set) Token: 0x06002EFC RID: 12028 RVA: 0x00081B80 File Offset: 0x0007FD80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonBuff RogueBuff
		{
			get
			{
				return this.rogueBuff_;
			}
			set
			{
				this.rogueBuff_ = value;
			}
		}

		// Token: 0x17000D73 RID: 3443
		// (get) Token: 0x06002EFD RID: 12029 RVA: 0x00081B89 File Offset: 0x0007FD89
		// (set) Token: 0x06002EFE RID: 12030 RVA: 0x00081B91 File Offset: 0x0007FD91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueBuffEnhanceList BuffEnhanceInfo
		{
			get
			{
				return this.buffEnhanceInfo_;
			}
			set
			{
				this.buffEnhanceInfo_ = value;
			}
		}

		// Token: 0x17000D74 RID: 3444
		// (get) Token: 0x06002EFF RID: 12031 RVA: 0x00081B9A File Offset: 0x0007FD9A
		// (set) Token: 0x06002F00 RID: 12032 RVA: 0x00081BA2 File Offset: 0x0007FDA2
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

		// Token: 0x17000D75 RID: 3445
		// (get) Token: 0x06002F01 RID: 12033 RVA: 0x00081BAB File Offset: 0x0007FDAB
		// (set) Token: 0x06002F02 RID: 12034 RVA: 0x00081BB3 File Offset: 0x0007FDB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsSuccess
		{
			get
			{
				return this.isSuccess_;
			}
			set
			{
				this.isSuccess_ = value;
			}
		}

		// Token: 0x06002F03 RID: 12035 RVA: 0x00081BBC File Offset: 0x0007FDBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnhanceChessRogueBuffScRsp);
		}

		// Token: 0x06002F04 RID: 12036 RVA: 0x00081BCC File Offset: 0x0007FDCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnhanceChessRogueBuffScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.RogueBuff, other.RogueBuff) && object.Equals(this.BuffEnhanceInfo, other.BuffEnhanceInfo) && this.Retcode == other.Retcode && this.IsSuccess == other.IsSuccess && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002F05 RID: 12037 RVA: 0x00081C40 File Offset: 0x0007FE40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.rogueBuff_ != null)
			{
				num ^= this.RogueBuff.GetHashCode();
			}
			if (this.buffEnhanceInfo_ != null)
			{
				num ^= this.BuffEnhanceInfo.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.IsSuccess)
			{
				num ^= this.IsSuccess.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002F06 RID: 12038 RVA: 0x00081CC4 File Offset: 0x0007FEC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002F07 RID: 12039 RVA: 0x00081CCC File Offset: 0x0007FECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002F08 RID: 12040 RVA: 0x00081CD8 File Offset: 0x0007FED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rogueBuff_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.RogueBuff);
			}
			if (this.buffEnhanceInfo_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.BuffEnhanceInfo);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.Retcode);
			}
			if (this.IsSuccess)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.IsSuccess);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002F09 RID: 12041 RVA: 0x00081D6C File Offset: 0x0007FF6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.rogueBuff_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueBuff);
			}
			if (this.buffEnhanceInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BuffEnhanceInfo);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.IsSuccess)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002F0A RID: 12042 RVA: 0x00081DE8 File Offset: 0x0007FFE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnhanceChessRogueBuffScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.rogueBuff_ != null)
			{
				if (this.rogueBuff_ == null)
				{
					this.RogueBuff = new RogueCommonBuff();
				}
				this.RogueBuff.MergeFrom(other.RogueBuff);
			}
			if (other.buffEnhanceInfo_ != null)
			{
				if (this.buffEnhanceInfo_ == null)
				{
					this.BuffEnhanceInfo = new ChessRogueBuffEnhanceList();
				}
				this.BuffEnhanceInfo.MergeFrom(other.BuffEnhanceInfo);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.IsSuccess)
			{
				this.IsSuccess = other.IsSuccess;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002F0B RID: 12043 RVA: 0x00081E90 File Offset: 0x00080090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002F0C RID: 12044 RVA: 0x00081E9C File Offset: 0x0008009C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 18U)
				{
					if (num == 10U)
					{
						if (this.rogueBuff_ == null)
						{
							this.RogueBuff = new RogueCommonBuff();
						}
						input.ReadMessage(this.RogueBuff);
						continue;
					}
					if (num == 18U)
					{
						if (this.buffEnhanceInfo_ == null)
						{
							this.BuffEnhanceInfo = new ChessRogueBuffEnhanceList();
						}
						input.ReadMessage(this.BuffEnhanceInfo);
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 96U)
					{
						this.IsSuccess = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040012D4 RID: 4820
		private static readonly MessageParser<EnhanceChessRogueBuffScRsp> _parser = new MessageParser<EnhanceChessRogueBuffScRsp>(() => new EnhanceChessRogueBuffScRsp());

		// Token: 0x040012D5 RID: 4821
		private UnknownFieldSet _unknownFields;

		// Token: 0x040012D6 RID: 4822
		public const int RogueBuffFieldNumber = 1;

		// Token: 0x040012D7 RID: 4823
		private RogueCommonBuff rogueBuff_;

		// Token: 0x040012D8 RID: 4824
		public const int BuffEnhanceInfoFieldNumber = 2;

		// Token: 0x040012D9 RID: 4825
		private ChessRogueBuffEnhanceList buffEnhanceInfo_;

		// Token: 0x040012DA RID: 4826
		public const int RetcodeFieldNumber = 6;

		// Token: 0x040012DB RID: 4827
		private uint retcode_;

		// Token: 0x040012DC RID: 4828
		public const int IsSuccessFieldNumber = 12;

		// Token: 0x040012DD RID: 4829
		private bool isSuccess_;
	}
}
