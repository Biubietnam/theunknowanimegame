using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001211 RID: 4625
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SwapLineupCsReq : IMessage<SwapLineupCsReq>, IMessage, IEquatable<SwapLineupCsReq>, IDeepCloneable<SwapLineupCsReq>, IBufferMessage
	{
		// Token: 0x17003A4A RID: 14922
		// (get) Token: 0x0600CEB6 RID: 52918 RVA: 0x0022A607 File Offset: 0x00228807
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SwapLineupCsReq> Parser
		{
			get
			{
				return SwapLineupCsReq._parser;
			}
		}

		// Token: 0x17003A4B RID: 14923
		// (get) Token: 0x0600CEB7 RID: 52919 RVA: 0x0022A60E File Offset: 0x0022880E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SwapLineupCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003A4C RID: 14924
		// (get) Token: 0x0600CEB8 RID: 52920 RVA: 0x0022A620 File Offset: 0x00228820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SwapLineupCsReq.Descriptor;
			}
		}

		// Token: 0x0600CEB9 RID: 52921 RVA: 0x0022A627 File Offset: 0x00228827
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwapLineupCsReq()
		{
		}

		// Token: 0x0600CEBA RID: 52922 RVA: 0x0022A630 File Offset: 0x00228830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwapLineupCsReq(SwapLineupCsReq other) : this()
		{
			this.index_ = other.index_;
			this.planeId_ = other.planeId_;
			this.ePLDFEFADKD_ = other.ePLDFEFADKD_;
			this.extraLineupType_ = other.extraLineupType_;
			this.isVirtual_ = other.isVirtual_;
			this.mPCNAEFFPKB_ = other.mPCNAEFFPKB_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CEBB RID: 52923 RVA: 0x0022A69C File Offset: 0x0022889C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwapLineupCsReq Clone()
		{
			return new SwapLineupCsReq(this);
		}

		// Token: 0x17003A4D RID: 14925
		// (get) Token: 0x0600CEBC RID: 52924 RVA: 0x0022A6A4 File Offset: 0x002288A4
		// (set) Token: 0x0600CEBD RID: 52925 RVA: 0x0022A6AC File Offset: 0x002288AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x17003A4E RID: 14926
		// (get) Token: 0x0600CEBE RID: 52926 RVA: 0x0022A6B5 File Offset: 0x002288B5
		// (set) Token: 0x0600CEBF RID: 52927 RVA: 0x0022A6BD File Offset: 0x002288BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PlaneId
		{
			get
			{
				return this.planeId_;
			}
			set
			{
				this.planeId_ = value;
			}
		}

		// Token: 0x17003A4F RID: 14927
		// (get) Token: 0x0600CEC0 RID: 52928 RVA: 0x0022A6C6 File Offset: 0x002288C6
		// (set) Token: 0x0600CEC1 RID: 52929 RVA: 0x0022A6CE File Offset: 0x002288CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EPLDFEFADKD
		{
			get
			{
				return this.ePLDFEFADKD_;
			}
			set
			{
				this.ePLDFEFADKD_ = value;
			}
		}

		// Token: 0x17003A50 RID: 14928
		// (get) Token: 0x0600CEC2 RID: 52930 RVA: 0x0022A6D7 File Offset: 0x002288D7
		// (set) Token: 0x0600CEC3 RID: 52931 RVA: 0x0022A6DF File Offset: 0x002288DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExtraLineupType ExtraLineupType
		{
			get
			{
				return this.extraLineupType_;
			}
			set
			{
				this.extraLineupType_ = value;
			}
		}

		// Token: 0x17003A51 RID: 14929
		// (get) Token: 0x0600CEC4 RID: 52932 RVA: 0x0022A6E8 File Offset: 0x002288E8
		// (set) Token: 0x0600CEC5 RID: 52933 RVA: 0x0022A6F0 File Offset: 0x002288F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsVirtual
		{
			get
			{
				return this.isVirtual_;
			}
			set
			{
				this.isVirtual_ = value;
			}
		}

		// Token: 0x17003A52 RID: 14930
		// (get) Token: 0x0600CEC6 RID: 52934 RVA: 0x0022A6F9 File Offset: 0x002288F9
		// (set) Token: 0x0600CEC7 RID: 52935 RVA: 0x0022A701 File Offset: 0x00228901
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MPCNAEFFPKB
		{
			get
			{
				return this.mPCNAEFFPKB_;
			}
			set
			{
				this.mPCNAEFFPKB_ = value;
			}
		}

		// Token: 0x0600CEC8 RID: 52936 RVA: 0x0022A70A File Offset: 0x0022890A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SwapLineupCsReq);
		}

		// Token: 0x0600CEC9 RID: 52937 RVA: 0x0022A718 File Offset: 0x00228918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SwapLineupCsReq other)
		{
			return other != null && (other == this || (this.Index == other.Index && this.PlaneId == other.PlaneId && this.EPLDFEFADKD == other.EPLDFEFADKD && this.ExtraLineupType == other.ExtraLineupType && this.IsVirtual == other.IsVirtual && this.MPCNAEFFPKB == other.MPCNAEFFPKB && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CECA RID: 52938 RVA: 0x0022A7A4 File Offset: 0x002289A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Index != 0U)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this.PlaneId != 0U)
			{
				num ^= this.PlaneId.GetHashCode();
			}
			if (this.EPLDFEFADKD != 0U)
			{
				num ^= this.EPLDFEFADKD.GetHashCode();
			}
			if (this.ExtraLineupType != ExtraLineupType.LineupNone)
			{
				num ^= this.ExtraLineupType.GetHashCode();
			}
			if (this.IsVirtual)
			{
				num ^= this.IsVirtual.GetHashCode();
			}
			if (this.MPCNAEFFPKB != 0U)
			{
				num ^= this.MPCNAEFFPKB.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CECB RID: 52939 RVA: 0x0022A866 File Offset: 0x00228A66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600CECC RID: 52940 RVA: 0x0022A86E File Offset: 0x00228A6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CECD RID: 52941 RVA: 0x0022A878 File Offset: 0x00228A78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsVirtual)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsVirtual);
			}
			if (this.MPCNAEFFPKB != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.MPCNAEFFPKB);
			}
			if (this.ExtraLineupType != ExtraLineupType.LineupNone)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ExtraLineupType);
			}
			if (this.Index != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.Index);
			}
			if (this.EPLDFEFADKD != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.EPLDFEFADKD);
			}
			if (this.PlaneId != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.PlaneId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CECE RID: 52942 RVA: 0x0022A944 File Offset: 0x00228B44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Index != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Index);
			}
			if (this.PlaneId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PlaneId);
			}
			if (this.EPLDFEFADKD != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EPLDFEFADKD);
			}
			if (this.ExtraLineupType != ExtraLineupType.LineupNone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ExtraLineupType);
			}
			if (this.IsVirtual)
			{
				num += 2;
			}
			if (this.MPCNAEFFPKB != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MPCNAEFFPKB);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CECF RID: 52943 RVA: 0x0022A9F0 File Offset: 0x00228BF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SwapLineupCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Index != 0U)
			{
				this.Index = other.Index;
			}
			if (other.PlaneId != 0U)
			{
				this.PlaneId = other.PlaneId;
			}
			if (other.EPLDFEFADKD != 0U)
			{
				this.EPLDFEFADKD = other.EPLDFEFADKD;
			}
			if (other.ExtraLineupType != ExtraLineupType.LineupNone)
			{
				this.ExtraLineupType = other.ExtraLineupType;
			}
			if (other.IsVirtual)
			{
				this.IsVirtual = other.IsVirtual;
			}
			if (other.MPCNAEFFPKB != 0U)
			{
				this.MPCNAEFFPKB = other.MPCNAEFFPKB;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CED0 RID: 52944 RVA: 0x0022AA90 File Offset: 0x00228C90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CED1 RID: 52945 RVA: 0x0022AA9C File Offset: 0x00228C9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 72U)
				{
					if (num == 24U)
					{
						this.IsVirtual = input.ReadBool();
						continue;
					}
					if (num == 32U)
					{
						this.MPCNAEFFPKB = input.ReadUInt32();
						continue;
					}
					if (num == 72U)
					{
						this.ExtraLineupType = (ExtraLineupType)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.Index = input.ReadUInt32();
						continue;
					}
					if (num == 112U)
					{
						this.EPLDFEFADKD = input.ReadUInt32();
						continue;
					}
					if (num == 120U)
					{
						this.PlaneId = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400533C RID: 21308
		private static readonly MessageParser<SwapLineupCsReq> _parser = new MessageParser<SwapLineupCsReq>(() => new SwapLineupCsReq());

		// Token: 0x0400533D RID: 21309
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400533E RID: 21310
		public const int IndexFieldNumber = 11;

		// Token: 0x0400533F RID: 21311
		private uint index_;

		// Token: 0x04005340 RID: 21312
		public const int PlaneIdFieldNumber = 15;

		// Token: 0x04005341 RID: 21313
		private uint planeId_;

		// Token: 0x04005342 RID: 21314
		public const int EPLDFEFADKDFieldNumber = 14;

		// Token: 0x04005343 RID: 21315
		private uint ePLDFEFADKD_;

		// Token: 0x04005344 RID: 21316
		public const int ExtraLineupTypeFieldNumber = 9;

		// Token: 0x04005345 RID: 21317
		private ExtraLineupType extraLineupType_;

		// Token: 0x04005346 RID: 21318
		public const int IsVirtualFieldNumber = 3;

		// Token: 0x04005347 RID: 21319
		private bool isVirtual_;

		// Token: 0x04005348 RID: 21320
		public const int MPCNAEFFPKBFieldNumber = 4;

		// Token: 0x04005349 RID: 21321
		private uint mPCNAEFFPKB_;
	}
}
