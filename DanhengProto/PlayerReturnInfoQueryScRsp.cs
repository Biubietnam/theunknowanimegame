using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000CD3 RID: 3283
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PlayerReturnInfoQueryScRsp : IMessage<PlayerReturnInfoQueryScRsp>, IMessage, IEquatable<PlayerReturnInfoQueryScRsp>, IDeepCloneable<PlayerReturnInfoQueryScRsp>, IBufferMessage
	{
		// Token: 0x17002939 RID: 10553
		// (get) Token: 0x06009271 RID: 37489 RVA: 0x001846D7 File Offset: 0x001828D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PlayerReturnInfoQueryScRsp> Parser
		{
			get
			{
				return PlayerReturnInfoQueryScRsp._parser;
			}
		}

		// Token: 0x1700293A RID: 10554
		// (get) Token: 0x06009272 RID: 37490 RVA: 0x001846DE File Offset: 0x001828DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PlayerReturnInfoQueryScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700293B RID: 10555
		// (get) Token: 0x06009273 RID: 37491 RVA: 0x001846F0 File Offset: 0x001828F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerReturnInfoQueryScRsp.Descriptor;
			}
		}

		// Token: 0x06009274 RID: 37492 RVA: 0x001846F7 File Offset: 0x001828F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerReturnInfoQueryScRsp()
		{
		}

		// Token: 0x06009275 RID: 37493 RVA: 0x00184700 File Offset: 0x00182900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerReturnInfoQueryScRsp(PlayerReturnInfoQueryScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.pHEJGLEMKKM_ = ((other.pHEJGLEMKKM_ != null) ? other.pHEJGLEMKKM_.Clone() : null);
			this.mMGCLGJNLCG_ = other.mMGCLGJNLCG_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009276 RID: 37494 RVA: 0x00184758 File Offset: 0x00182958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerReturnInfoQueryScRsp Clone()
		{
			return new PlayerReturnInfoQueryScRsp(this);
		}

		// Token: 0x1700293C RID: 10556
		// (get) Token: 0x06009277 RID: 37495 RVA: 0x00184760 File Offset: 0x00182960
		// (set) Token: 0x06009278 RID: 37496 RVA: 0x00184768 File Offset: 0x00182968
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

		// Token: 0x1700293D RID: 10557
		// (get) Token: 0x06009279 RID: 37497 RVA: 0x00184771 File Offset: 0x00182971
		// (set) Token: 0x0600927A RID: 37498 RVA: 0x00184779 File Offset: 0x00182979
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OINMIFEJJPF PHEJGLEMKKM
		{
			get
			{
				return this.pHEJGLEMKKM_;
			}
			set
			{
				this.pHEJGLEMKKM_ = value;
			}
		}

		// Token: 0x1700293E RID: 10558
		// (get) Token: 0x0600927B RID: 37499 RVA: 0x00184782 File Offset: 0x00182982
		// (set) Token: 0x0600927C RID: 37500 RVA: 0x0018478A File Offset: 0x0018298A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MMGCLGJNLCG
		{
			get
			{
				return this.mMGCLGJNLCG_;
			}
			set
			{
				this.mMGCLGJNLCG_ = value;
			}
		}

		// Token: 0x0600927D RID: 37501 RVA: 0x00184793 File Offset: 0x00182993
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerReturnInfoQueryScRsp);
		}

		// Token: 0x0600927E RID: 37502 RVA: 0x001847A4 File Offset: 0x001829A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerReturnInfoQueryScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.PHEJGLEMKKM, other.PHEJGLEMKKM) && this.MMGCLGJNLCG == other.MMGCLGJNLCG && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600927F RID: 37503 RVA: 0x00184804 File Offset: 0x00182A04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.pHEJGLEMKKM_ != null)
			{
				num ^= this.PHEJGLEMKKM.GetHashCode();
			}
			if (this.MMGCLGJNLCG != 0U)
			{
				num ^= this.MMGCLGJNLCG.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009280 RID: 37504 RVA: 0x00184872 File Offset: 0x00182A72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009281 RID: 37505 RVA: 0x0018487A File Offset: 0x00182A7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009282 RID: 37506 RVA: 0x00184884 File Offset: 0x00182A84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Retcode);
			}
			if (this.MMGCLGJNLCG != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.MMGCLGJNLCG);
			}
			if (this.pHEJGLEMKKM_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.PHEJGLEMKKM);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009283 RID: 37507 RVA: 0x001848FC File Offset: 0x00182AFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.pHEJGLEMKKM_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PHEJGLEMKKM);
			}
			if (this.MMGCLGJNLCG != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MMGCLGJNLCG);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009284 RID: 37508 RVA: 0x0018496C File Offset: 0x00182B6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerReturnInfoQueryScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.pHEJGLEMKKM_ != null)
			{
				if (this.pHEJGLEMKKM_ == null)
				{
					this.PHEJGLEMKKM = new OINMIFEJJPF();
				}
				this.PHEJGLEMKKM.MergeFrom(other.PHEJGLEMKKM);
			}
			if (other.MMGCLGJNLCG != 0U)
			{
				this.MMGCLGJNLCG = other.MMGCLGJNLCG;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009285 RID: 37509 RVA: 0x001849E8 File Offset: 0x00182BE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009286 RID: 37510 RVA: 0x001849F4 File Offset: 0x00182BF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 32U)
					{
						if (num != 82U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.pHEJGLEMKKM_ == null)
							{
								this.PHEJGLEMKKM = new OINMIFEJJPF();
							}
							input.ReadMessage(this.PHEJGLEMKKM);
						}
					}
					else
					{
						this.MMGCLGJNLCG = input.ReadUInt32();
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003881 RID: 14465
		private static readonly MessageParser<PlayerReturnInfoQueryScRsp> _parser = new MessageParser<PlayerReturnInfoQueryScRsp>(() => new PlayerReturnInfoQueryScRsp());

		// Token: 0x04003882 RID: 14466
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003883 RID: 14467
		public const int RetcodeFieldNumber = 3;

		// Token: 0x04003884 RID: 14468
		private uint retcode_;

		// Token: 0x04003885 RID: 14469
		public const int PHEJGLEMKKMFieldNumber = 10;

		// Token: 0x04003886 RID: 14470
		private OINMIFEJJPF pHEJGLEMKKM_;

		// Token: 0x04003887 RID: 14471
		public const int MMGCLGJNLCGFieldNumber = 4;

		// Token: 0x04003888 RID: 14472
		private uint mMGCLGJNLCG_;
	}
}
