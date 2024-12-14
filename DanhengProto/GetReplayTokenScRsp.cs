using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200079B RID: 1947
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetReplayTokenScRsp : IMessage<GetReplayTokenScRsp>, IMessage, IEquatable<GetReplayTokenScRsp>, IDeepCloneable<GetReplayTokenScRsp>, IBufferMessage
	{
		// Token: 0x17001896 RID: 6294
		// (get) Token: 0x060056F3 RID: 22259 RVA: 0x000E91FF File Offset: 0x000E73FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetReplayTokenScRsp> Parser
		{
			get
			{
				return GetReplayTokenScRsp._parser;
			}
		}

		// Token: 0x17001897 RID: 6295
		// (get) Token: 0x060056F4 RID: 22260 RVA: 0x000E9206 File Offset: 0x000E7406
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetReplayTokenScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001898 RID: 6296
		// (get) Token: 0x060056F5 RID: 22261 RVA: 0x000E9218 File Offset: 0x000E7418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetReplayTokenScRsp.Descriptor;
			}
		}

		// Token: 0x060056F6 RID: 22262 RVA: 0x000E921F File Offset: 0x000E741F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetReplayTokenScRsp()
		{
		}

		// Token: 0x060056F7 RID: 22263 RVA: 0x000E9240 File Offset: 0x000E7440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetReplayTokenScRsp(GetReplayTokenScRsp other) : this()
		{
			this.stageId_ = other.stageId_;
			this.bNCOODAHHPC_ = other.bNCOODAHHPC_;
			this.retcode_ = other.retcode_;
			this.replayType_ = other.replayType_;
			this.token_ = other.token_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060056F8 RID: 22264 RVA: 0x000E92A0 File Offset: 0x000E74A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetReplayTokenScRsp Clone()
		{
			return new GetReplayTokenScRsp(this);
		}

		// Token: 0x17001899 RID: 6297
		// (get) Token: 0x060056F9 RID: 22265 RVA: 0x000E92A8 File Offset: 0x000E74A8
		// (set) Token: 0x060056FA RID: 22266 RVA: 0x000E92B0 File Offset: 0x000E74B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint StageId
		{
			get
			{
				return this.stageId_;
			}
			set
			{
				this.stageId_ = value;
			}
		}

		// Token: 0x1700189A RID: 6298
		// (get) Token: 0x060056FB RID: 22267 RVA: 0x000E92B9 File Offset: 0x000E74B9
		// (set) Token: 0x060056FC RID: 22268 RVA: 0x000E92C1 File Offset: 0x000E74C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string BNCOODAHHPC
		{
			get
			{
				return this.bNCOODAHHPC_;
			}
			set
			{
				this.bNCOODAHHPC_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700189B RID: 6299
		// (get) Token: 0x060056FD RID: 22269 RVA: 0x000E92D4 File Offset: 0x000E74D4
		// (set) Token: 0x060056FE RID: 22270 RVA: 0x000E92DC File Offset: 0x000E74DC
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

		// Token: 0x1700189C RID: 6300
		// (get) Token: 0x060056FF RID: 22271 RVA: 0x000E92E5 File Offset: 0x000E74E5
		// (set) Token: 0x06005700 RID: 22272 RVA: 0x000E92ED File Offset: 0x000E74ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReplayType ReplayType
		{
			get
			{
				return this.replayType_;
			}
			set
			{
				this.replayType_ = value;
			}
		}

		// Token: 0x1700189D RID: 6301
		// (get) Token: 0x06005701 RID: 22273 RVA: 0x000E92F6 File Offset: 0x000E74F6
		// (set) Token: 0x06005702 RID: 22274 RVA: 0x000E92FE File Offset: 0x000E74FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Token
		{
			get
			{
				return this.token_;
			}
			set
			{
				this.token_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x06005703 RID: 22275 RVA: 0x000E9311 File Offset: 0x000E7511
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetReplayTokenScRsp);
		}

		// Token: 0x06005704 RID: 22276 RVA: 0x000E9320 File Offset: 0x000E7520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetReplayTokenScRsp other)
		{
			return other != null && (other == this || (this.StageId == other.StageId && !(this.BNCOODAHHPC != other.BNCOODAHHPC) && this.Retcode == other.Retcode && this.ReplayType == other.ReplayType && !(this.Token != other.Token) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005705 RID: 22277 RVA: 0x000E93A4 File Offset: 0x000E75A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.StageId != 0U)
			{
				num ^= this.StageId.GetHashCode();
			}
			if (this.BNCOODAHHPC.Length != 0)
			{
				num ^= this.BNCOODAHHPC.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.ReplayType != ReplayType.None)
			{
				num ^= this.ReplayType.GetHashCode();
			}
			if (this.Token.Length != 0)
			{
				num ^= this.Token.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005706 RID: 22278 RVA: 0x000E9451 File Offset: 0x000E7651
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005707 RID: 22279 RVA: 0x000E9459 File Offset: 0x000E7659
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005708 RID: 22280 RVA: 0x000E9464 File Offset: 0x000E7664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ReplayType != ReplayType.None)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ReplayType);
			}
			if (this.Token.Length != 0)
			{
				output.WriteRawTag(58);
				output.WriteString(this.Token);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Retcode);
			}
			if (this.StageId != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.StageId);
			}
			if (this.BNCOODAHHPC.Length != 0)
			{
				output.WriteRawTag(106);
				output.WriteString(this.BNCOODAHHPC);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005709 RID: 22281 RVA: 0x000E951C File Offset: 0x000E771C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.StageId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.StageId);
			}
			if (this.BNCOODAHHPC.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.BNCOODAHHPC);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.ReplayType != ReplayType.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ReplayType);
			}
			if (this.Token.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Token);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600570A RID: 22282 RVA: 0x000E95C4 File Offset: 0x000E77C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetReplayTokenScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.StageId != 0U)
			{
				this.StageId = other.StageId;
			}
			if (other.BNCOODAHHPC.Length != 0)
			{
				this.BNCOODAHHPC = other.BNCOODAHHPC;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.ReplayType != ReplayType.None)
			{
				this.ReplayType = other.ReplayType;
			}
			if (other.Token.Length != 0)
			{
				this.Token = other.Token;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600570B RID: 22283 RVA: 0x000E965A File Offset: 0x000E785A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600570C RID: 22284 RVA: 0x000E9664 File Offset: 0x000E7864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 58U)
				{
					if (num == 48U)
					{
						this.ReplayType = (ReplayType)input.ReadEnum();
						continue;
					}
					if (num == 58U)
					{
						this.Token = input.ReadString();
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 96U)
					{
						this.StageId = input.ReadUInt32();
						continue;
					}
					if (num == 106U)
					{
						this.BNCOODAHHPC = input.ReadString();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002205 RID: 8709
		private static readonly MessageParser<GetReplayTokenScRsp> _parser = new MessageParser<GetReplayTokenScRsp>(() => new GetReplayTokenScRsp());

		// Token: 0x04002206 RID: 8710
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002207 RID: 8711
		public const int StageIdFieldNumber = 12;

		// Token: 0x04002208 RID: 8712
		private uint stageId_;

		// Token: 0x04002209 RID: 8713
		public const int BNCOODAHHPCFieldNumber = 13;

		// Token: 0x0400220A RID: 8714
		private string bNCOODAHHPC_ = "";

		// Token: 0x0400220B RID: 8715
		public const int RetcodeFieldNumber = 8;

		// Token: 0x0400220C RID: 8716
		private uint retcode_;

		// Token: 0x0400220D RID: 8717
		public const int ReplayTypeFieldNumber = 6;

		// Token: 0x0400220E RID: 8718
		private ReplayType replayType_;

		// Token: 0x0400220F RID: 8719
		public const int TokenFieldNumber = 7;

		// Token: 0x04002210 RID: 8720
		private string token_ = "";
	}
}
