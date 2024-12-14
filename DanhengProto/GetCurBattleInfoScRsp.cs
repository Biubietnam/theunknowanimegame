using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000671 RID: 1649
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetCurBattleInfoScRsp : IMessage<GetCurBattleInfoScRsp>, IMessage, IEquatable<GetCurBattleInfoScRsp>, IDeepCloneable<GetCurBattleInfoScRsp>, IBufferMessage
	{
		// Token: 0x17001507 RID: 5383
		// (get) Token: 0x060049E0 RID: 18912 RVA: 0x000C9433 File Offset: 0x000C7633
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetCurBattleInfoScRsp> Parser
		{
			get
			{
				return GetCurBattleInfoScRsp._parser;
			}
		}

		// Token: 0x17001508 RID: 5384
		// (get) Token: 0x060049E1 RID: 18913 RVA: 0x000C943A File Offset: 0x000C763A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetCurBattleInfoScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001509 RID: 5385
		// (get) Token: 0x060049E2 RID: 18914 RVA: 0x000C944C File Offset: 0x000C764C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetCurBattleInfoScRsp.Descriptor;
			}
		}

		// Token: 0x060049E3 RID: 18915 RVA: 0x000C9453 File Offset: 0x000C7653
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetCurBattleInfoScRsp()
		{
		}

		// Token: 0x060049E4 RID: 18916 RVA: 0x000C945C File Offset: 0x000C765C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetCurBattleInfoScRsp(GetCurBattleInfoScRsp other) : this()
		{
			this.fMLMGOMEIKM_ = ((other.fMLMGOMEIKM_ != null) ? other.fMLMGOMEIKM_.Clone() : null);
			this.lastEndStatus_ = other.lastEndStatus_;
			this.retcode_ = other.retcode_;
			this.nBHCNLGPIDO_ = other.nBHCNLGPIDO_;
			this.battleInfo_ = ((other.battleInfo_ != null) ? other.battleInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060049E5 RID: 18917 RVA: 0x000C94DC File Offset: 0x000C76DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetCurBattleInfoScRsp Clone()
		{
			return new GetCurBattleInfoScRsp(this);
		}

		// Token: 0x1700150A RID: 5386
		// (get) Token: 0x060049E6 RID: 18918 RVA: 0x000C94E4 File Offset: 0x000C76E4
		// (set) Token: 0x060049E7 RID: 18919 RVA: 0x000C94EC File Offset: 0x000C76EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AetherDivideBattleInfo FMLMGOMEIKM
		{
			get
			{
				return this.fMLMGOMEIKM_;
			}
			set
			{
				this.fMLMGOMEIKM_ = value;
			}
		}

		// Token: 0x1700150B RID: 5387
		// (get) Token: 0x060049E8 RID: 18920 RVA: 0x000C94F5 File Offset: 0x000C76F5
		// (set) Token: 0x060049E9 RID: 18921 RVA: 0x000C94FD File Offset: 0x000C76FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleEndStatus LastEndStatus
		{
			get
			{
				return this.lastEndStatus_;
			}
			set
			{
				this.lastEndStatus_ = value;
			}
		}

		// Token: 0x1700150C RID: 5388
		// (get) Token: 0x060049EA RID: 18922 RVA: 0x000C9506 File Offset: 0x000C7706
		// (set) Token: 0x060049EB RID: 18923 RVA: 0x000C950E File Offset: 0x000C770E
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

		// Token: 0x1700150D RID: 5389
		// (get) Token: 0x060049EC RID: 18924 RVA: 0x000C9517 File Offset: 0x000C7717
		// (set) Token: 0x060049ED RID: 18925 RVA: 0x000C951F File Offset: 0x000C771F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint NBHCNLGPIDO
		{
			get
			{
				return this.nBHCNLGPIDO_;
			}
			set
			{
				this.nBHCNLGPIDO_ = value;
			}
		}

		// Token: 0x1700150E RID: 5390
		// (get) Token: 0x060049EE RID: 18926 RVA: 0x000C9528 File Offset: 0x000C7728
		// (set) Token: 0x060049EF RID: 18927 RVA: 0x000C9530 File Offset: 0x000C7730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneBattleInfo BattleInfo
		{
			get
			{
				return this.battleInfo_;
			}
			set
			{
				this.battleInfo_ = value;
			}
		}

		// Token: 0x060049F0 RID: 18928 RVA: 0x000C9539 File Offset: 0x000C7739
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetCurBattleInfoScRsp);
		}

		// Token: 0x060049F1 RID: 18929 RVA: 0x000C9548 File Offset: 0x000C7748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetCurBattleInfoScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.FMLMGOMEIKM, other.FMLMGOMEIKM) && this.LastEndStatus == other.LastEndStatus && this.Retcode == other.Retcode && this.NBHCNLGPIDO == other.NBHCNLGPIDO && object.Equals(this.BattleInfo, other.BattleInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060049F2 RID: 18930 RVA: 0x000C95CC File Offset: 0x000C77CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.fMLMGOMEIKM_ != null)
			{
				num ^= this.FMLMGOMEIKM.GetHashCode();
			}
			if (this.LastEndStatus != BattleEndStatus.BattleEndNone)
			{
				num ^= this.LastEndStatus.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.NBHCNLGPIDO != 0U)
			{
				num ^= this.NBHCNLGPIDO.GetHashCode();
			}
			if (this.battleInfo_ != null)
			{
				num ^= this.BattleInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060049F3 RID: 18931 RVA: 0x000C966F File Offset: 0x000C786F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060049F4 RID: 18932 RVA: 0x000C9677 File Offset: 0x000C7877
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060049F5 RID: 18933 RVA: 0x000C9680 File Offset: 0x000C7880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LastEndStatus != BattleEndStatus.BattleEndNone)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.LastEndStatus);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Retcode);
			}
			if (this.fMLMGOMEIKM_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.FMLMGOMEIKM);
			}
			if (this.NBHCNLGPIDO != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.NBHCNLGPIDO);
			}
			if (this.battleInfo_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.BattleInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060049F6 RID: 18934 RVA: 0x000C9730 File Offset: 0x000C7930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.fMLMGOMEIKM_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FMLMGOMEIKM);
			}
			if (this.LastEndStatus != BattleEndStatus.BattleEndNone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.LastEndStatus);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.NBHCNLGPIDO != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NBHCNLGPIDO);
			}
			if (this.battleInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BattleInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060049F7 RID: 18935 RVA: 0x000C97D0 File Offset: 0x000C79D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetCurBattleInfoScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.fMLMGOMEIKM_ != null)
			{
				if (this.fMLMGOMEIKM_ == null)
				{
					this.FMLMGOMEIKM = new AetherDivideBattleInfo();
				}
				this.FMLMGOMEIKM.MergeFrom(other.FMLMGOMEIKM);
			}
			if (other.LastEndStatus != BattleEndStatus.BattleEndNone)
			{
				this.LastEndStatus = other.LastEndStatus;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.NBHCNLGPIDO != 0U)
			{
				this.NBHCNLGPIDO = other.NBHCNLGPIDO;
			}
			if (other.battleInfo_ != null)
			{
				if (this.battleInfo_ == null)
				{
					this.BattleInfo = new SceneBattleInfo();
				}
				this.BattleInfo.MergeFrom(other.BattleInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060049F8 RID: 18936 RVA: 0x000C988C File Offset: 0x000C7A8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060049F9 RID: 18937 RVA: 0x000C9898 File Offset: 0x000C7A98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 32U)
				{
					if (num == 24U)
					{
						this.LastEndStatus = (BattleEndStatus)input.ReadEnum();
						continue;
					}
					if (num == 32U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 82U)
					{
						if (this.fMLMGOMEIKM_ == null)
						{
							this.FMLMGOMEIKM = new AetherDivideBattleInfo();
						}
						input.ReadMessage(this.FMLMGOMEIKM);
						continue;
					}
					if (num == 88U)
					{
						this.NBHCNLGPIDO = input.ReadUInt32();
						continue;
					}
					if (num == 114U)
					{
						if (this.battleInfo_ == null)
						{
							this.BattleInfo = new SceneBattleInfo();
						}
						input.ReadMessage(this.BattleInfo);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001D5E RID: 7518
		private static readonly MessageParser<GetCurBattleInfoScRsp> _parser = new MessageParser<GetCurBattleInfoScRsp>(() => new GetCurBattleInfoScRsp());

		// Token: 0x04001D5F RID: 7519
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001D60 RID: 7520
		public const int FMLMGOMEIKMFieldNumber = 10;

		// Token: 0x04001D61 RID: 7521
		private AetherDivideBattleInfo fMLMGOMEIKM_;

		// Token: 0x04001D62 RID: 7522
		public const int LastEndStatusFieldNumber = 3;

		// Token: 0x04001D63 RID: 7523
		private BattleEndStatus lastEndStatus_;

		// Token: 0x04001D64 RID: 7524
		public const int RetcodeFieldNumber = 4;

		// Token: 0x04001D65 RID: 7525
		private uint retcode_;

		// Token: 0x04001D66 RID: 7526
		public const int NBHCNLGPIDOFieldNumber = 11;

		// Token: 0x04001D67 RID: 7527
		private uint nBHCNLGPIDO_;

		// Token: 0x04001D68 RID: 7528
		public const int BattleInfoFieldNumber = 14;

		// Token: 0x04001D69 RID: 7529
		private SceneBattleInfo battleInfo_;
	}
}
