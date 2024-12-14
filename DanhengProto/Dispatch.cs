using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020003A9 RID: 937
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class Dispatch : IMessage<Dispatch>, IMessage, IEquatable<Dispatch>, IDeepCloneable<Dispatch>, IBufferMessage
	{
		// Token: 0x17000BEA RID: 3050
		// (get) Token: 0x06002997 RID: 10647 RVA: 0x000738A7 File Offset: 0x00071AA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<Dispatch> Parser
		{
			get
			{
				return Dispatch._parser;
			}
		}

		// Token: 0x17000BEB RID: 3051
		// (get) Token: 0x06002998 RID: 10648 RVA: 0x000738AE File Offset: 0x00071AAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DispatchReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000BEC RID: 3052
		// (get) Token: 0x06002999 RID: 10649 RVA: 0x000738C0 File Offset: 0x00071AC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Dispatch.Descriptor;
			}
		}

		// Token: 0x0600299A RID: 10650 RVA: 0x000738C7 File Offset: 0x00071AC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Dispatch()
		{
		}

		// Token: 0x0600299B RID: 10651 RVA: 0x000738FC File Offset: 0x00071AFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Dispatch(Dispatch other) : this()
		{
			this.retcode_ = other.retcode_;
			this.msg_ = other.msg_;
			this.topSeverRegionName_ = other.topSeverRegionName_;
			this.regionList_ = other.regionList_.Clone();
			this.stopDesc_ = other.stopDesc_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600299C RID: 10652 RVA: 0x00073961 File Offset: 0x00071B61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Dispatch Clone()
		{
			return new Dispatch(this);
		}

		// Token: 0x17000BED RID: 3053
		// (get) Token: 0x0600299D RID: 10653 RVA: 0x00073969 File Offset: 0x00071B69
		// (set) Token: 0x0600299E RID: 10654 RVA: 0x00073971 File Offset: 0x00071B71
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

		// Token: 0x17000BEE RID: 3054
		// (get) Token: 0x0600299F RID: 10655 RVA: 0x0007397A File Offset: 0x00071B7A
		// (set) Token: 0x060029A0 RID: 10656 RVA: 0x00073982 File Offset: 0x00071B82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Msg
		{
			get
			{
				return this.msg_;
			}
			set
			{
				this.msg_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000BEF RID: 3055
		// (get) Token: 0x060029A1 RID: 10657 RVA: 0x00073995 File Offset: 0x00071B95
		// (set) Token: 0x060029A2 RID: 10658 RVA: 0x0007399D File Offset: 0x00071B9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string TopSeverRegionName
		{
			get
			{
				return this.topSeverRegionName_;
			}
			set
			{
				this.topSeverRegionName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000BF0 RID: 3056
		// (get) Token: 0x060029A3 RID: 10659 RVA: 0x000739B0 File Offset: 0x00071BB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RegionInfo> RegionList
		{
			get
			{
				return this.regionList_;
			}
		}

		// Token: 0x17000BF1 RID: 3057
		// (get) Token: 0x060029A4 RID: 10660 RVA: 0x000739B8 File Offset: 0x00071BB8
		// (set) Token: 0x060029A5 RID: 10661 RVA: 0x000739C0 File Offset: 0x00071BC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string StopDesc
		{
			get
			{
				return this.stopDesc_;
			}
			set
			{
				this.stopDesc_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x060029A6 RID: 10662 RVA: 0x000739D3 File Offset: 0x00071BD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as Dispatch);
		}

		// Token: 0x060029A7 RID: 10663 RVA: 0x000739E4 File Offset: 0x00071BE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(Dispatch other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && !(this.Msg != other.Msg) && !(this.TopSeverRegionName != other.TopSeverRegionName) && this.regionList_.Equals(other.regionList_) && !(this.StopDesc != other.StopDesc) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060029A8 RID: 10664 RVA: 0x00073A74 File Offset: 0x00071C74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.Msg.Length != 0)
			{
				num ^= this.Msg.GetHashCode();
			}
			if (this.TopSeverRegionName.Length != 0)
			{
				num ^= this.TopSeverRegionName.GetHashCode();
			}
			num ^= this.regionList_.GetHashCode();
			if (this.StopDesc.Length != 0)
			{
				num ^= this.StopDesc.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060029A9 RID: 10665 RVA: 0x00073B12 File Offset: 0x00071D12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060029AA RID: 10666 RVA: 0x00073B1A File Offset: 0x00071D1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060029AB RID: 10667 RVA: 0x00073B24 File Offset: 0x00071D24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Retcode);
			}
			if (this.Msg.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Msg);
			}
			if (this.TopSeverRegionName.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteString(this.TopSeverRegionName);
			}
			this.regionList_.WriteTo(ref output, Dispatch._repeated_regionList_codec);
			if (this.StopDesc.Length != 0)
			{
				output.WriteRawTag(42);
				output.WriteString(this.StopDesc);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060029AC RID: 10668 RVA: 0x00073BD4 File Offset: 0x00071DD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.Msg.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Msg);
			}
			if (this.TopSeverRegionName.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.TopSeverRegionName);
			}
			num += this.regionList_.CalculateSize(Dispatch._repeated_regionList_codec);
			if (this.StopDesc.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.StopDesc);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060029AD RID: 10669 RVA: 0x00073C7C File Offset: 0x00071E7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(Dispatch other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.Msg.Length != 0)
			{
				this.Msg = other.Msg;
			}
			if (other.TopSeverRegionName.Length != 0)
			{
				this.TopSeverRegionName = other.TopSeverRegionName;
			}
			this.regionList_.Add(other.regionList_);
			if (other.StopDesc.Length != 0)
			{
				this.StopDesc = other.StopDesc;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060029AE RID: 10670 RVA: 0x00073D14 File Offset: 0x00071F14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060029AF RID: 10671 RVA: 0x00073D20 File Offset: 0x00071F20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 18U)
				{
					if (num == 8U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 18U)
					{
						this.Msg = input.ReadString();
						continue;
					}
				}
				else
				{
					if (num == 26U)
					{
						this.TopSeverRegionName = input.ReadString();
						continue;
					}
					if (num == 34U)
					{
						this.regionList_.AddEntriesFrom(ref input, Dispatch._repeated_regionList_codec);
						continue;
					}
					if (num == 42U)
					{
						this.StopDesc = input.ReadString();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040010C3 RID: 4291
		private static readonly MessageParser<Dispatch> _parser = new MessageParser<Dispatch>(() => new Dispatch());

		// Token: 0x040010C4 RID: 4292
		private UnknownFieldSet _unknownFields;

		// Token: 0x040010C5 RID: 4293
		public const int RetcodeFieldNumber = 1;

		// Token: 0x040010C6 RID: 4294
		private uint retcode_;

		// Token: 0x040010C7 RID: 4295
		public const int MsgFieldNumber = 2;

		// Token: 0x040010C8 RID: 4296
		private string msg_ = "";

		// Token: 0x040010C9 RID: 4297
		public const int TopSeverRegionNameFieldNumber = 3;

		// Token: 0x040010CA RID: 4298
		private string topSeverRegionName_ = "";

		// Token: 0x040010CB RID: 4299
		public const int RegionListFieldNumber = 4;

		// Token: 0x040010CC RID: 4300
		private static readonly FieldCodec<RegionInfo> _repeated_regionList_codec = FieldCodec.ForMessage<RegionInfo>(34U, RegionInfo.Parser);

		// Token: 0x040010CD RID: 4301
		private readonly RepeatedField<RegionInfo> regionList_ = new RepeatedField<RegionInfo>();

		// Token: 0x040010CE RID: 4302
		public const int StopDescFieldNumber = 5;

		// Token: 0x040010CF RID: 4303
		private string stopDesc_ = "";
	}
}
