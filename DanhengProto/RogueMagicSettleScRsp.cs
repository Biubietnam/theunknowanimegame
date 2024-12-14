using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F1D RID: 3869
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueMagicSettleScRsp : IMessage<RogueMagicSettleScRsp>, IMessage, IEquatable<RogueMagicSettleScRsp>, IDeepCloneable<RogueMagicSettleScRsp>, IBufferMessage
	{
		// Token: 0x170030B6 RID: 12470
		// (get) Token: 0x0600AC9A RID: 44186 RVA: 0x001D05A4 File Offset: 0x001CE7A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueMagicSettleScRsp> Parser
		{
			get
			{
				return RogueMagicSettleScRsp._parser;
			}
		}

		// Token: 0x170030B7 RID: 12471
		// (get) Token: 0x0600AC9B RID: 44187 RVA: 0x001D05AB File Offset: 0x001CE7AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueMagicSettleScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170030B8 RID: 12472
		// (get) Token: 0x0600AC9C RID: 44188 RVA: 0x001D05BD File Offset: 0x001CE7BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueMagicSettleScRsp.Descriptor;
			}
		}

		// Token: 0x0600AC9D RID: 44189 RVA: 0x001D05C4 File Offset: 0x001CE7C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicSettleScRsp()
		{
		}

		// Token: 0x0600AC9E RID: 44190 RVA: 0x001D05CC File Offset: 0x001CE7CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicSettleScRsp(RogueMagicSettleScRsp other) : this()
		{
			this.hELHOBNAJIL_ = ((other.hELHOBNAJIL_ != null) ? other.hELHOBNAJIL_.Clone() : null);
			this.rogueTournCurSceneInfo_ = ((other.rogueTournCurSceneInfo_ != null) ? other.rogueTournCurSceneInfo_.Clone() : null);
			this.tournFinishInfo_ = ((other.tournFinishInfo_ != null) ? other.tournFinishInfo_.Clone() : null);
			this.eHPMBDCAIPE_ = ((other.eHPMBDCAIPE_ != null) ? other.eHPMBDCAIPE_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AC9F RID: 44191 RVA: 0x001D066C File Offset: 0x001CE86C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicSettleScRsp Clone()
		{
			return new RogueMagicSettleScRsp(this);
		}

		// Token: 0x170030B9 RID: 12473
		// (get) Token: 0x0600ACA0 RID: 44192 RVA: 0x001D0674 File Offset: 0x001CE874
		// (set) Token: 0x0600ACA1 RID: 44193 RVA: 0x001D067C File Offset: 0x001CE87C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemList HELHOBNAJIL
		{
			get
			{
				return this.hELHOBNAJIL_;
			}
			set
			{
				this.hELHOBNAJIL_ = value;
			}
		}

		// Token: 0x170030BA RID: 12474
		// (get) Token: 0x0600ACA2 RID: 44194 RVA: 0x001D0685 File Offset: 0x001CE885
		// (set) Token: 0x0600ACA3 RID: 44195 RVA: 0x001D068D File Offset: 0x001CE88D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicCurSceneInfo RogueTournCurSceneInfo
		{
			get
			{
				return this.rogueTournCurSceneInfo_;
			}
			set
			{
				this.rogueTournCurSceneInfo_ = value;
			}
		}

		// Token: 0x170030BB RID: 12475
		// (get) Token: 0x0600ACA4 RID: 44196 RVA: 0x001D0696 File Offset: 0x001CE896
		// (set) Token: 0x0600ACA5 RID: 44197 RVA: 0x001D069E File Offset: 0x001CE89E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicFinishInfo TournFinishInfo
		{
			get
			{
				return this.tournFinishInfo_;
			}
			set
			{
				this.tournFinishInfo_ = value;
			}
		}

		// Token: 0x170030BC RID: 12476
		// (get) Token: 0x0600ACA6 RID: 44198 RVA: 0x001D06A7 File Offset: 0x001CE8A7
		// (set) Token: 0x0600ACA7 RID: 44199 RVA: 0x001D06AF File Offset: 0x001CE8AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JNDMKHIBCPJ EHPMBDCAIPE
		{
			get
			{
				return this.eHPMBDCAIPE_;
			}
			set
			{
				this.eHPMBDCAIPE_ = value;
			}
		}

		// Token: 0x170030BD RID: 12477
		// (get) Token: 0x0600ACA8 RID: 44200 RVA: 0x001D06B8 File Offset: 0x001CE8B8
		// (set) Token: 0x0600ACA9 RID: 44201 RVA: 0x001D06C0 File Offset: 0x001CE8C0
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

		// Token: 0x0600ACAA RID: 44202 RVA: 0x001D06C9 File Offset: 0x001CE8C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueMagicSettleScRsp);
		}

		// Token: 0x0600ACAB RID: 44203 RVA: 0x001D06D8 File Offset: 0x001CE8D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueMagicSettleScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.HELHOBNAJIL, other.HELHOBNAJIL) && object.Equals(this.RogueTournCurSceneInfo, other.RogueTournCurSceneInfo) && object.Equals(this.TournFinishInfo, other.TournFinishInfo) && object.Equals(this.EHPMBDCAIPE, other.EHPMBDCAIPE) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600ACAC RID: 44204 RVA: 0x001D0768 File Offset: 0x001CE968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.hELHOBNAJIL_ != null)
			{
				num ^= this.HELHOBNAJIL.GetHashCode();
			}
			if (this.rogueTournCurSceneInfo_ != null)
			{
				num ^= this.RogueTournCurSceneInfo.GetHashCode();
			}
			if (this.tournFinishInfo_ != null)
			{
				num ^= this.TournFinishInfo.GetHashCode();
			}
			if (this.eHPMBDCAIPE_ != null)
			{
				num ^= this.EHPMBDCAIPE.GetHashCode();
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

		// Token: 0x0600ACAD RID: 44205 RVA: 0x001D07FF File Offset: 0x001CE9FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600ACAE RID: 44206 RVA: 0x001D0807 File Offset: 0x001CEA07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600ACAF RID: 44207 RVA: 0x001D0810 File Offset: 0x001CEA10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rogueTournCurSceneInfo_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.RogueTournCurSceneInfo);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.Retcode);
			}
			if (this.tournFinishInfo_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.TournFinishInfo);
			}
			if (this.hELHOBNAJIL_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.HELHOBNAJIL);
			}
			if (this.eHPMBDCAIPE_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.EHPMBDCAIPE);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600ACB0 RID: 44208 RVA: 0x001D08C0 File Offset: 0x001CEAC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.hELHOBNAJIL_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.HELHOBNAJIL);
			}
			if (this.rogueTournCurSceneInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueTournCurSceneInfo);
			}
			if (this.tournFinishInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TournFinishInfo);
			}
			if (this.eHPMBDCAIPE_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EHPMBDCAIPE);
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

		// Token: 0x0600ACB1 RID: 44209 RVA: 0x001D0960 File Offset: 0x001CEB60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueMagicSettleScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.hELHOBNAJIL_ != null)
			{
				if (this.hELHOBNAJIL_ == null)
				{
					this.HELHOBNAJIL = new ItemList();
				}
				this.HELHOBNAJIL.MergeFrom(other.HELHOBNAJIL);
			}
			if (other.rogueTournCurSceneInfo_ != null)
			{
				if (this.rogueTournCurSceneInfo_ == null)
				{
					this.RogueTournCurSceneInfo = new RogueMagicCurSceneInfo();
				}
				this.RogueTournCurSceneInfo.MergeFrom(other.RogueTournCurSceneInfo);
			}
			if (other.tournFinishInfo_ != null)
			{
				if (this.tournFinishInfo_ == null)
				{
					this.TournFinishInfo = new RogueMagicFinishInfo();
				}
				this.TournFinishInfo.MergeFrom(other.TournFinishInfo);
			}
			if (other.eHPMBDCAIPE_ != null)
			{
				if (this.eHPMBDCAIPE_ == null)
				{
					this.EHPMBDCAIPE = new JNDMKHIBCPJ();
				}
				this.EHPMBDCAIPE.MergeFrom(other.EHPMBDCAIPE);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600ACB2 RID: 44210 RVA: 0x001D0A4C File Offset: 0x001CEC4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600ACB3 RID: 44211 RVA: 0x001D0A58 File Offset: 0x001CEC58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 48U)
				{
					if (num == 34U)
					{
						if (this.rogueTournCurSceneInfo_ == null)
						{
							this.RogueTournCurSceneInfo = new RogueMagicCurSceneInfo();
						}
						input.ReadMessage(this.RogueTournCurSceneInfo);
						continue;
					}
					if (num == 48U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 66U)
					{
						if (this.tournFinishInfo_ == null)
						{
							this.TournFinishInfo = new RogueMagicFinishInfo();
						}
						input.ReadMessage(this.TournFinishInfo);
						continue;
					}
					if (num == 74U)
					{
						if (this.hELHOBNAJIL_ == null)
						{
							this.HELHOBNAJIL = new ItemList();
						}
						input.ReadMessage(this.HELHOBNAJIL);
						continue;
					}
					if (num == 122U)
					{
						if (this.eHPMBDCAIPE_ == null)
						{
							this.EHPMBDCAIPE = new JNDMKHIBCPJ();
						}
						input.ReadMessage(this.EHPMBDCAIPE);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004654 RID: 18004
		private static readonly MessageParser<RogueMagicSettleScRsp> _parser = new MessageParser<RogueMagicSettleScRsp>(() => new RogueMagicSettleScRsp());

		// Token: 0x04004655 RID: 18005
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004656 RID: 18006
		public const int HELHOBNAJILFieldNumber = 9;

		// Token: 0x04004657 RID: 18007
		private ItemList hELHOBNAJIL_;

		// Token: 0x04004658 RID: 18008
		public const int RogueTournCurSceneInfoFieldNumber = 4;

		// Token: 0x04004659 RID: 18009
		private RogueMagicCurSceneInfo rogueTournCurSceneInfo_;

		// Token: 0x0400465A RID: 18010
		public const int TournFinishInfoFieldNumber = 8;

		// Token: 0x0400465B RID: 18011
		private RogueMagicFinishInfo tournFinishInfo_;

		// Token: 0x0400465C RID: 18012
		public const int EHPMBDCAIPEFieldNumber = 15;

		// Token: 0x0400465D RID: 18013
		private JNDMKHIBCPJ eHPMBDCAIPE_;

		// Token: 0x0400465E RID: 18014
		public const int RetcodeFieldNumber = 6;

		// Token: 0x0400465F RID: 18015
		private uint retcode_;
	}
}
