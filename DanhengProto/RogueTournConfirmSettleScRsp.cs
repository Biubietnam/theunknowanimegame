using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F89 RID: 3977
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournConfirmSettleScRsp : IMessage<RogueTournConfirmSettleScRsp>, IMessage, IEquatable<RogueTournConfirmSettleScRsp>, IDeepCloneable<RogueTournConfirmSettleScRsp>, IBufferMessage
	{
		// Token: 0x170031F3 RID: 12787
		// (get) Token: 0x0600B118 RID: 45336 RVA: 0x001DBAE4 File Offset: 0x001D9CE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournConfirmSettleScRsp> Parser
		{
			get
			{
				return RogueTournConfirmSettleScRsp._parser;
			}
		}

		// Token: 0x170031F4 RID: 12788
		// (get) Token: 0x0600B119 RID: 45337 RVA: 0x001DBAEB File Offset: 0x001D9CEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournConfirmSettleScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170031F5 RID: 12789
		// (get) Token: 0x0600B11A RID: 45338 RVA: 0x001DBAFD File Offset: 0x001D9CFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournConfirmSettleScRsp.Descriptor;
			}
		}

		// Token: 0x0600B11B RID: 45339 RVA: 0x001DBB04 File Offset: 0x001D9D04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournConfirmSettleScRsp()
		{
		}

		// Token: 0x0600B11C RID: 45340 RVA: 0x001DBB0C File Offset: 0x001D9D0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournConfirmSettleScRsp(RogueTournConfirmSettleScRsp other) : this()
		{
			this.rogueTournCurSceneInfo_ = ((other.rogueTournCurSceneInfo_ != null) ? other.rogueTournCurSceneInfo_.Clone() : null);
			this.hELHOBNAJIL_ = ((other.hELHOBNAJIL_ != null) ? other.hELHOBNAJIL_.Clone() : null);
			this.nOMGPBAHEGN_ = ((other.nOMGPBAHEGN_ != null) ? other.nOMGPBAHEGN_.Clone() : null);
			this.gJBGBAAKNPN_ = ((other.gJBGBAAKNPN_ != null) ? other.gJBGBAAKNPN_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B11D RID: 45341 RVA: 0x001DBBAC File Offset: 0x001D9DAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournConfirmSettleScRsp Clone()
		{
			return new RogueTournConfirmSettleScRsp(this);
		}

		// Token: 0x170031F6 RID: 12790
		// (get) Token: 0x0600B11E RID: 45342 RVA: 0x001DBBB4 File Offset: 0x001D9DB4
		// (set) Token: 0x0600B11F RID: 45343 RVA: 0x001DBBBC File Offset: 0x001D9DBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournCurSceneInfo RogueTournCurSceneInfo
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

		// Token: 0x170031F7 RID: 12791
		// (get) Token: 0x0600B120 RID: 45344 RVA: 0x001DBBC5 File Offset: 0x001D9DC5
		// (set) Token: 0x0600B121 RID: 45345 RVA: 0x001DBBCD File Offset: 0x001D9DCD
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

		// Token: 0x170031F8 RID: 12792
		// (get) Token: 0x0600B122 RID: 45346 RVA: 0x001DBBD6 File Offset: 0x001D9DD6
		// (set) Token: 0x0600B123 RID: 45347 RVA: 0x001DBBDE File Offset: 0x001D9DDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemList NOMGPBAHEGN
		{
			get
			{
				return this.nOMGPBAHEGN_;
			}
			set
			{
				this.nOMGPBAHEGN_ = value;
			}
		}

		// Token: 0x170031F9 RID: 12793
		// (get) Token: 0x0600B124 RID: 45348 RVA: 0x001DBBE7 File Offset: 0x001D9DE7
		// (set) Token: 0x0600B125 RID: 45349 RVA: 0x001DBBEF File Offset: 0x001D9DEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournSaveList GJBGBAAKNPN
		{
			get
			{
				return this.gJBGBAAKNPN_;
			}
			set
			{
				this.gJBGBAAKNPN_ = value;
			}
		}

		// Token: 0x170031FA RID: 12794
		// (get) Token: 0x0600B126 RID: 45350 RVA: 0x001DBBF8 File Offset: 0x001D9DF8
		// (set) Token: 0x0600B127 RID: 45351 RVA: 0x001DBC00 File Offset: 0x001D9E00
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

		// Token: 0x0600B128 RID: 45352 RVA: 0x001DBC09 File Offset: 0x001D9E09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournConfirmSettleScRsp);
		}

		// Token: 0x0600B129 RID: 45353 RVA: 0x001DBC18 File Offset: 0x001D9E18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournConfirmSettleScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.RogueTournCurSceneInfo, other.RogueTournCurSceneInfo) && object.Equals(this.HELHOBNAJIL, other.HELHOBNAJIL) && object.Equals(this.NOMGPBAHEGN, other.NOMGPBAHEGN) && object.Equals(this.GJBGBAAKNPN, other.GJBGBAAKNPN) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B12A RID: 45354 RVA: 0x001DBCA8 File Offset: 0x001D9EA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.rogueTournCurSceneInfo_ != null)
			{
				num ^= this.RogueTournCurSceneInfo.GetHashCode();
			}
			if (this.hELHOBNAJIL_ != null)
			{
				num ^= this.HELHOBNAJIL.GetHashCode();
			}
			if (this.nOMGPBAHEGN_ != null)
			{
				num ^= this.NOMGPBAHEGN.GetHashCode();
			}
			if (this.gJBGBAAKNPN_ != null)
			{
				num ^= this.GJBGBAAKNPN.GetHashCode();
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

		// Token: 0x0600B12B RID: 45355 RVA: 0x001DBD3F File Offset: 0x001D9F3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B12C RID: 45356 RVA: 0x001DBD47 File Offset: 0x001D9F47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B12D RID: 45357 RVA: 0x001DBD50 File Offset: 0x001D9F50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Retcode);
			}
			if (this.hELHOBNAJIL_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.HELHOBNAJIL);
			}
			if (this.rogueTournCurSceneInfo_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.RogueTournCurSceneInfo);
			}
			if (this.gJBGBAAKNPN_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.GJBGBAAKNPN);
			}
			if (this.nOMGPBAHEGN_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.NOMGPBAHEGN);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B12E RID: 45358 RVA: 0x001DBDFC File Offset: 0x001D9FFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.rogueTournCurSceneInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueTournCurSceneInfo);
			}
			if (this.hELHOBNAJIL_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.HELHOBNAJIL);
			}
			if (this.nOMGPBAHEGN_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.NOMGPBAHEGN);
			}
			if (this.gJBGBAAKNPN_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GJBGBAAKNPN);
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

		// Token: 0x0600B12F RID: 45359 RVA: 0x001DBE9C File Offset: 0x001DA09C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournConfirmSettleScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.rogueTournCurSceneInfo_ != null)
			{
				if (this.rogueTournCurSceneInfo_ == null)
				{
					this.RogueTournCurSceneInfo = new RogueTournCurSceneInfo();
				}
				this.RogueTournCurSceneInfo.MergeFrom(other.RogueTournCurSceneInfo);
			}
			if (other.hELHOBNAJIL_ != null)
			{
				if (this.hELHOBNAJIL_ == null)
				{
					this.HELHOBNAJIL = new ItemList();
				}
				this.HELHOBNAJIL.MergeFrom(other.HELHOBNAJIL);
			}
			if (other.nOMGPBAHEGN_ != null)
			{
				if (this.nOMGPBAHEGN_ == null)
				{
					this.NOMGPBAHEGN = new ItemList();
				}
				this.NOMGPBAHEGN.MergeFrom(other.NOMGPBAHEGN);
			}
			if (other.gJBGBAAKNPN_ != null)
			{
				if (this.gJBGBAAKNPN_ == null)
				{
					this.GJBGBAAKNPN = new RogueTournSaveList();
				}
				this.GJBGBAAKNPN.MergeFrom(other.GJBGBAAKNPN);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B130 RID: 45360 RVA: 0x001DBF88 File Offset: 0x001DA188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B131 RID: 45361 RVA: 0x001DBF94 File Offset: 0x001DA194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 58U)
				{
					if (num == 8U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 58U)
					{
						if (this.hELHOBNAJIL_ == null)
						{
							this.HELHOBNAJIL = new ItemList();
						}
						input.ReadMessage(this.HELHOBNAJIL);
						continue;
					}
				}
				else
				{
					if (num == 66U)
					{
						if (this.rogueTournCurSceneInfo_ == null)
						{
							this.RogueTournCurSceneInfo = new RogueTournCurSceneInfo();
						}
						input.ReadMessage(this.RogueTournCurSceneInfo);
						continue;
					}
					if (num == 74U)
					{
						if (this.gJBGBAAKNPN_ == null)
						{
							this.GJBGBAAKNPN = new RogueTournSaveList();
						}
						input.ReadMessage(this.GJBGBAAKNPN);
						continue;
					}
					if (num == 82U)
					{
						if (this.nOMGPBAHEGN_ == null)
						{
							this.NOMGPBAHEGN = new ItemList();
						}
						input.ReadMessage(this.NOMGPBAHEGN);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004809 RID: 18441
		private static readonly MessageParser<RogueTournConfirmSettleScRsp> _parser = new MessageParser<RogueTournConfirmSettleScRsp>(() => new RogueTournConfirmSettleScRsp());

		// Token: 0x0400480A RID: 18442
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400480B RID: 18443
		public const int RogueTournCurSceneInfoFieldNumber = 8;

		// Token: 0x0400480C RID: 18444
		private RogueTournCurSceneInfo rogueTournCurSceneInfo_;

		// Token: 0x0400480D RID: 18445
		public const int HELHOBNAJILFieldNumber = 7;

		// Token: 0x0400480E RID: 18446
		private ItemList hELHOBNAJIL_;

		// Token: 0x0400480F RID: 18447
		public const int NOMGPBAHEGNFieldNumber = 10;

		// Token: 0x04004810 RID: 18448
		private ItemList nOMGPBAHEGN_;

		// Token: 0x04004811 RID: 18449
		public const int GJBGBAAKNPNFieldNumber = 9;

		// Token: 0x04004812 RID: 18450
		private RogueTournSaveList gJBGBAAKNPN_;

		// Token: 0x04004813 RID: 18451
		public const int RetcodeFieldNumber = 1;

		// Token: 0x04004814 RID: 18452
		private uint retcode_;
	}
}
