using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200093B RID: 2363
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class InteractTreasureDungeonGridCsReq : IMessage<InteractTreasureDungeonGridCsReq>, IMessage, IEquatable<InteractTreasureDungeonGridCsReq>, IDeepCloneable<InteractTreasureDungeonGridCsReq>, IBufferMessage
	{
		// Token: 0x17001DA6 RID: 7590
		// (get) Token: 0x06006970 RID: 26992 RVA: 0x00119763 File Offset: 0x00117963
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<InteractTreasureDungeonGridCsReq> Parser
		{
			get
			{
				return InteractTreasureDungeonGridCsReq._parser;
			}
		}

		// Token: 0x17001DA7 RID: 7591
		// (get) Token: 0x06006971 RID: 26993 RVA: 0x0011976A File Offset: 0x0011796A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return InteractTreasureDungeonGridCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001DA8 RID: 7592
		// (get) Token: 0x06006972 RID: 26994 RVA: 0x0011977C File Offset: 0x0011797C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InteractTreasureDungeonGridCsReq.Descriptor;
			}
		}

		// Token: 0x06006973 RID: 26995 RVA: 0x00119783 File Offset: 0x00117983
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InteractTreasureDungeonGridCsReq()
		{
		}

		// Token: 0x06006974 RID: 26996 RVA: 0x0011978B File Offset: 0x0011798B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InteractTreasureDungeonGridCsReq(InteractTreasureDungeonGridCsReq other) : this()
		{
			this.eEEABJCNKDO_ = other.eEEABJCNKDO_;
			this.displayValue_ = other.displayValue_;
			this.nCFAJPAMBGD_ = other.nCFAJPAMBGD_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006975 RID: 26997 RVA: 0x001197C8 File Offset: 0x001179C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InteractTreasureDungeonGridCsReq Clone()
		{
			return new InteractTreasureDungeonGridCsReq(this);
		}

		// Token: 0x17001DA9 RID: 7593
		// (get) Token: 0x06006976 RID: 26998 RVA: 0x001197D0 File Offset: 0x001179D0
		// (set) Token: 0x06006977 RID: 26999 RVA: 0x001197D8 File Offset: 0x001179D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EEEABJCNKDO
		{
			get
			{
				return this.eEEABJCNKDO_;
			}
			set
			{
				this.eEEABJCNKDO_ = value;
			}
		}

		// Token: 0x17001DAA RID: 7594
		// (get) Token: 0x06006978 RID: 27000 RVA: 0x001197E1 File Offset: 0x001179E1
		// (set) Token: 0x06006979 RID: 27001 RVA: 0x001197E9 File Offset: 0x001179E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DisplayValue
		{
			get
			{
				return this.displayValue_;
			}
			set
			{
				this.displayValue_ = value;
			}
		}

		// Token: 0x17001DAB RID: 7595
		// (get) Token: 0x0600697A RID: 27002 RVA: 0x001197F2 File Offset: 0x001179F2
		// (set) Token: 0x0600697B RID: 27003 RVA: 0x001197FA File Offset: 0x001179FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint NCFAJPAMBGD
		{
			get
			{
				return this.nCFAJPAMBGD_;
			}
			set
			{
				this.nCFAJPAMBGD_ = value;
			}
		}

		// Token: 0x0600697C RID: 27004 RVA: 0x00119803 File Offset: 0x00117A03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InteractTreasureDungeonGridCsReq);
		}

		// Token: 0x0600697D RID: 27005 RVA: 0x00119814 File Offset: 0x00117A14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InteractTreasureDungeonGridCsReq other)
		{
			return other != null && (other == this || (this.EEEABJCNKDO == other.EEEABJCNKDO && this.DisplayValue == other.DisplayValue && this.NCFAJPAMBGD == other.NCFAJPAMBGD && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600697E RID: 27006 RVA: 0x00119870 File Offset: 0x00117A70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EEEABJCNKDO != 0U)
			{
				num ^= this.EEEABJCNKDO.GetHashCode();
			}
			if (this.DisplayValue != 0U)
			{
				num ^= this.DisplayValue.GetHashCode();
			}
			if (this.NCFAJPAMBGD != 0U)
			{
				num ^= this.NCFAJPAMBGD.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600697F RID: 27007 RVA: 0x001198E1 File Offset: 0x00117AE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006980 RID: 27008 RVA: 0x001198E9 File Offset: 0x00117AE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006981 RID: 27009 RVA: 0x001198F4 File Offset: 0x00117AF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NCFAJPAMBGD != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.NCFAJPAMBGD);
			}
			if (this.EEEABJCNKDO != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.EEEABJCNKDO);
			}
			if (this.DisplayValue != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.DisplayValue);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006982 RID: 27010 RVA: 0x0011996C File Offset: 0x00117B6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EEEABJCNKDO != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EEEABJCNKDO);
			}
			if (this.DisplayValue != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DisplayValue);
			}
			if (this.NCFAJPAMBGD != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NCFAJPAMBGD);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006983 RID: 27011 RVA: 0x001199DC File Offset: 0x00117BDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InteractTreasureDungeonGridCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EEEABJCNKDO != 0U)
			{
				this.EEEABJCNKDO = other.EEEABJCNKDO;
			}
			if (other.DisplayValue != 0U)
			{
				this.DisplayValue = other.DisplayValue;
			}
			if (other.NCFAJPAMBGD != 0U)
			{
				this.NCFAJPAMBGD = other.NCFAJPAMBGD;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006984 RID: 27012 RVA: 0x00119A40 File Offset: 0x00117C40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006985 RID: 27013 RVA: 0x00119A4C File Offset: 0x00117C4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 48U)
					{
						if (num != 80U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.DisplayValue = input.ReadUInt32();
						}
					}
					else
					{
						this.EEEABJCNKDO = input.ReadUInt32();
					}
				}
				else
				{
					this.NCFAJPAMBGD = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002868 RID: 10344
		private static readonly MessageParser<InteractTreasureDungeonGridCsReq> _parser = new MessageParser<InteractTreasureDungeonGridCsReq>(() => new InteractTreasureDungeonGridCsReq());

		// Token: 0x04002869 RID: 10345
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400286A RID: 10346
		public const int EEEABJCNKDOFieldNumber = 6;

		// Token: 0x0400286B RID: 10347
		private uint eEEABJCNKDO_;

		// Token: 0x0400286C RID: 10348
		public const int DisplayValueFieldNumber = 10;

		// Token: 0x0400286D RID: 10349
		private uint displayValue_;

		// Token: 0x0400286E RID: 10350
		public const int NCFAJPAMBGDFieldNumber = 2;

		// Token: 0x0400286F RID: 10351
		private uint nCFAJPAMBGD_;
	}
}
