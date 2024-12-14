using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000CC9 RID: 3273
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PlayerLoginScRsp : IMessage<PlayerLoginScRsp>, IMessage, IEquatable<PlayerLoginScRsp>, IDeepCloneable<PlayerLoginScRsp>, IBufferMessage
	{
		// Token: 0x17002910 RID: 10512
		// (get) Token: 0x060091E8 RID: 37352 RVA: 0x00182E31 File Offset: 0x00181031
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PlayerLoginScRsp> Parser
		{
			get
			{
				return PlayerLoginScRsp._parser;
			}
		}

		// Token: 0x17002911 RID: 10513
		// (get) Token: 0x060091E9 RID: 37353 RVA: 0x00182E38 File Offset: 0x00181038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PlayerLoginScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002912 RID: 10514
		// (get) Token: 0x060091EA RID: 37354 RVA: 0x00182E4A File Offset: 0x0018104A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerLoginScRsp.Descriptor;
			}
		}

		// Token: 0x060091EB RID: 37355 RVA: 0x00182E51 File Offset: 0x00181051
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerLoginScRsp()
		{
		}

		// Token: 0x060091EC RID: 37356 RVA: 0x00182E70 File Offset: 0x00181070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerLoginScRsp(PlayerLoginScRsp other) : this()
		{
			this.basicInfo_ = ((other.basicInfo_ != null) ? other.basicInfo_.Clone() : null);
			this.nDFEAEIHBFJ_ = other.nDFEAEIHBFJ_;
			this.retcode_ = other.retcode_;
			this.curTimezone_ = other.curTimezone_;
			this.serverTimestampMs_ = other.serverTimestampMs_;
			this.stamina_ = other.stamina_;
			this.loginRandom_ = other.loginRandom_;
			this.lJMFOHLOBCI_ = other.lJMFOHLOBCI_;
			this.dMAAMAMCNKJ_ = other.dMAAMAMCNKJ_;
			this.jOPPAENDMFJ_ = other.jOPPAENDMFJ_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060091ED RID: 37357 RVA: 0x00182F1C File Offset: 0x0018111C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerLoginScRsp Clone()
		{
			return new PlayerLoginScRsp(this);
		}

		// Token: 0x17002913 RID: 10515
		// (get) Token: 0x060091EE RID: 37358 RVA: 0x00182F24 File Offset: 0x00181124
		// (set) Token: 0x060091EF RID: 37359 RVA: 0x00182F2C File Offset: 0x0018112C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerBasicInfo BasicInfo
		{
			get
			{
				return this.basicInfo_;
			}
			set
			{
				this.basicInfo_ = value;
			}
		}

		// Token: 0x17002914 RID: 10516
		// (get) Token: 0x060091F0 RID: 37360 RVA: 0x00182F35 File Offset: 0x00181135
		// (set) Token: 0x060091F1 RID: 37361 RVA: 0x00182F3D File Offset: 0x0018113D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string NDFEAEIHBFJ
		{
			get
			{
				return this.nDFEAEIHBFJ_;
			}
			set
			{
				this.nDFEAEIHBFJ_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002915 RID: 10517
		// (get) Token: 0x060091F2 RID: 37362 RVA: 0x00182F50 File Offset: 0x00181150
		// (set) Token: 0x060091F3 RID: 37363 RVA: 0x00182F58 File Offset: 0x00181158
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

		// Token: 0x17002916 RID: 10518
		// (get) Token: 0x060091F4 RID: 37364 RVA: 0x00182F61 File Offset: 0x00181161
		// (set) Token: 0x060091F5 RID: 37365 RVA: 0x00182F69 File Offset: 0x00181169
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurTimezone
		{
			get
			{
				return this.curTimezone_;
			}
			set
			{
				this.curTimezone_ = value;
			}
		}

		// Token: 0x17002917 RID: 10519
		// (get) Token: 0x060091F6 RID: 37366 RVA: 0x00182F72 File Offset: 0x00181172
		// (set) Token: 0x060091F7 RID: 37367 RVA: 0x00182F7A File Offset: 0x0018117A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ulong ServerTimestampMs
		{
			get
			{
				return this.serverTimestampMs_;
			}
			set
			{
				this.serverTimestampMs_ = value;
			}
		}

		// Token: 0x17002918 RID: 10520
		// (get) Token: 0x060091F8 RID: 37368 RVA: 0x00182F83 File Offset: 0x00181183
		// (set) Token: 0x060091F9 RID: 37369 RVA: 0x00182F8B File Offset: 0x0018118B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Stamina
		{
			get
			{
				return this.stamina_;
			}
			set
			{
				this.stamina_ = value;
			}
		}

		// Token: 0x17002919 RID: 10521
		// (get) Token: 0x060091FA RID: 37370 RVA: 0x00182F94 File Offset: 0x00181194
		// (set) Token: 0x060091FB RID: 37371 RVA: 0x00182F9C File Offset: 0x0018119C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ulong LoginRandom
		{
			get
			{
				return this.loginRandom_;
			}
			set
			{
				this.loginRandom_ = value;
			}
		}

		// Token: 0x1700291A RID: 10522
		// (get) Token: 0x060091FC RID: 37372 RVA: 0x00182FA5 File Offset: 0x001811A5
		// (set) Token: 0x060091FD RID: 37373 RVA: 0x00182FAD File Offset: 0x001811AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool LJMFOHLOBCI
		{
			get
			{
				return this.lJMFOHLOBCI_;
			}
			set
			{
				this.lJMFOHLOBCI_ = value;
			}
		}

		// Token: 0x1700291B RID: 10523
		// (get) Token: 0x060091FE RID: 37374 RVA: 0x00182FB6 File Offset: 0x001811B6
		// (set) Token: 0x060091FF RID: 37375 RVA: 0x00182FBE File Offset: 0x001811BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string DMAAMAMCNKJ
		{
			get
			{
				return this.dMAAMAMCNKJ_;
			}
			set
			{
				this.dMAAMAMCNKJ_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700291C RID: 10524
		// (get) Token: 0x06009200 RID: 37376 RVA: 0x00182FD1 File Offset: 0x001811D1
		// (set) Token: 0x06009201 RID: 37377 RVA: 0x00182FD9 File Offset: 0x001811D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool JOPPAENDMFJ
		{
			get
			{
				return this.jOPPAENDMFJ_;
			}
			set
			{
				this.jOPPAENDMFJ_ = value;
			}
		}

		// Token: 0x06009202 RID: 37378 RVA: 0x00182FE2 File Offset: 0x001811E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerLoginScRsp);
		}

		// Token: 0x06009203 RID: 37379 RVA: 0x00182FF0 File Offset: 0x001811F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerLoginScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.BasicInfo, other.BasicInfo) && !(this.NDFEAEIHBFJ != other.NDFEAEIHBFJ) && this.Retcode == other.Retcode && this.CurTimezone == other.CurTimezone && this.ServerTimestampMs == other.ServerTimestampMs && this.Stamina == other.Stamina && this.LoginRandom == other.LoginRandom && this.LJMFOHLOBCI == other.LJMFOHLOBCI && !(this.DMAAMAMCNKJ != other.DMAAMAMCNKJ) && this.JOPPAENDMFJ == other.JOPPAENDMFJ && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009204 RID: 37380 RVA: 0x001830C8 File Offset: 0x001812C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.basicInfo_ != null)
			{
				num ^= this.BasicInfo.GetHashCode();
			}
			if (this.NDFEAEIHBFJ.Length != 0)
			{
				num ^= this.NDFEAEIHBFJ.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.CurTimezone != 0)
			{
				num ^= this.CurTimezone.GetHashCode();
			}
			if (this.ServerTimestampMs != 0UL)
			{
				num ^= this.ServerTimestampMs.GetHashCode();
			}
			if (this.Stamina != 0U)
			{
				num ^= this.Stamina.GetHashCode();
			}
			if (this.LoginRandom != 0UL)
			{
				num ^= this.LoginRandom.GetHashCode();
			}
			if (this.LJMFOHLOBCI)
			{
				num ^= this.LJMFOHLOBCI.GetHashCode();
			}
			if (this.DMAAMAMCNKJ.Length != 0)
			{
				num ^= this.DMAAMAMCNKJ.GetHashCode();
			}
			if (this.JOPPAENDMFJ)
			{
				num ^= this.JOPPAENDMFJ.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009205 RID: 37381 RVA: 0x001831EB File Offset: 0x001813EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009206 RID: 37382 RVA: 0x001831F3 File Offset: 0x001813F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009207 RID: 37383 RVA: 0x001831FC File Offset: 0x001813FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LoginRandom != 0UL)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.LoginRandom);
			}
			if (this.LJMFOHLOBCI)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.LJMFOHLOBCI);
			}
			if (this.basicInfo_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.BasicInfo);
			}
			if (this.NDFEAEIHBFJ.Length != 0)
			{
				output.WriteRawTag(50);
				output.WriteString(this.NDFEAEIHBFJ);
			}
			if (this.CurTimezone != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.CurTimezone);
			}
			if (this.ServerTimestampMs != 0UL)
			{
				output.WriteRawTag(64);
				output.WriteUInt64(this.ServerTimestampMs);
			}
			if (this.JOPPAENDMFJ)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.JOPPAENDMFJ);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.Retcode);
			}
			if (this.DMAAMAMCNKJ.Length != 0)
			{
				output.WriteRawTag(98);
				output.WriteString(this.DMAAMAMCNKJ);
			}
			if (this.Stamina != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.Stamina);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009208 RID: 37384 RVA: 0x00183340 File Offset: 0x00181540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.basicInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BasicInfo);
			}
			if (this.NDFEAEIHBFJ.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.NDFEAEIHBFJ);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.CurTimezone != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurTimezone);
			}
			if (this.ServerTimestampMs != 0UL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.ServerTimestampMs);
			}
			if (this.Stamina != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Stamina);
			}
			if (this.LoginRandom != 0UL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.LoginRandom);
			}
			if (this.LJMFOHLOBCI)
			{
				num += 2;
			}
			if (this.DMAAMAMCNKJ.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.DMAAMAMCNKJ);
			}
			if (this.JOPPAENDMFJ)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009209 RID: 37385 RVA: 0x00183448 File Offset: 0x00181648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerLoginScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.basicInfo_ != null)
			{
				if (this.basicInfo_ == null)
				{
					this.BasicInfo = new PlayerBasicInfo();
				}
				this.BasicInfo.MergeFrom(other.BasicInfo);
			}
			if (other.NDFEAEIHBFJ.Length != 0)
			{
				this.NDFEAEIHBFJ = other.NDFEAEIHBFJ;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.CurTimezone != 0)
			{
				this.CurTimezone = other.CurTimezone;
			}
			if (other.ServerTimestampMs != 0UL)
			{
				this.ServerTimestampMs = other.ServerTimestampMs;
			}
			if (other.Stamina != 0U)
			{
				this.Stamina = other.Stamina;
			}
			if (other.LoginRandom != 0UL)
			{
				this.LoginRandom = other.LoginRandom;
			}
			if (other.LJMFOHLOBCI)
			{
				this.LJMFOHLOBCI = other.LJMFOHLOBCI;
			}
			if (other.DMAAMAMCNKJ.Length != 0)
			{
				this.DMAAMAMCNKJ = other.DMAAMAMCNKJ;
			}
			if (other.JOPPAENDMFJ)
			{
				this.JOPPAENDMFJ = other.JOPPAENDMFJ;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600920A RID: 37386 RVA: 0x0018355A File Offset: 0x0018175A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600920B RID: 37387 RVA: 0x00183564 File Offset: 0x00181764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 56U)
				{
					if (num <= 24U)
					{
						if (num == 16U)
						{
							this.LoginRandom = input.ReadUInt64();
							continue;
						}
						if (num == 24U)
						{
							this.LJMFOHLOBCI = input.ReadBool();
							continue;
						}
					}
					else
					{
						if (num == 34U)
						{
							if (this.basicInfo_ == null)
							{
								this.BasicInfo = new PlayerBasicInfo();
							}
							input.ReadMessage(this.BasicInfo);
							continue;
						}
						if (num == 50U)
						{
							this.NDFEAEIHBFJ = input.ReadString();
							continue;
						}
						if (num == 56U)
						{
							this.CurTimezone = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 72U)
				{
					if (num == 64U)
					{
						this.ServerTimestampMs = input.ReadUInt64();
						continue;
					}
					if (num == 72U)
					{
						this.JOPPAENDMFJ = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 98U)
					{
						this.DMAAMAMCNKJ = input.ReadString();
						continue;
					}
					if (num == 112U)
					{
						this.Stamina = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003848 RID: 14408
		private static readonly MessageParser<PlayerLoginScRsp> _parser = new MessageParser<PlayerLoginScRsp>(() => new PlayerLoginScRsp());

		// Token: 0x04003849 RID: 14409
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400384A RID: 14410
		public const int BasicInfoFieldNumber = 4;

		// Token: 0x0400384B RID: 14411
		private PlayerBasicInfo basicInfo_;

		// Token: 0x0400384C RID: 14412
		public const int NDFEAEIHBFJFieldNumber = 6;

		// Token: 0x0400384D RID: 14413
		private string nDFEAEIHBFJ_ = "";

		// Token: 0x0400384E RID: 14414
		public const int RetcodeFieldNumber = 10;

		// Token: 0x0400384F RID: 14415
		private uint retcode_;

		// Token: 0x04003850 RID: 14416
		public const int CurTimezoneFieldNumber = 7;

		// Token: 0x04003851 RID: 14417
		private int curTimezone_;

		// Token: 0x04003852 RID: 14418
		public const int ServerTimestampMsFieldNumber = 8;

		// Token: 0x04003853 RID: 14419
		private ulong serverTimestampMs_;

		// Token: 0x04003854 RID: 14420
		public const int StaminaFieldNumber = 14;

		// Token: 0x04003855 RID: 14421
		private uint stamina_;

		// Token: 0x04003856 RID: 14422
		public const int LoginRandomFieldNumber = 2;

		// Token: 0x04003857 RID: 14423
		private ulong loginRandom_;

		// Token: 0x04003858 RID: 14424
		public const int LJMFOHLOBCIFieldNumber = 3;

		// Token: 0x04003859 RID: 14425
		private bool lJMFOHLOBCI_;

		// Token: 0x0400385A RID: 14426
		public const int DMAAMAMCNKJFieldNumber = 12;

		// Token: 0x0400385B RID: 14427
		private string dMAAMAMCNKJ_ = "";

		// Token: 0x0400385C RID: 14428
		public const int JOPPAENDMFJFieldNumber = 9;

		// Token: 0x0400385D RID: 14429
		private bool jOPPAENDMFJ_;
	}
}
