using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020012CD RID: 4813
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TakeChapterRewardScRsp : IMessage<TakeChapterRewardScRsp>, IMessage, IEquatable<TakeChapterRewardScRsp>, IDeepCloneable<TakeChapterRewardScRsp>, IBufferMessage
	{
		// Token: 0x17003C5A RID: 15450
		// (get) Token: 0x0600D6AE RID: 54958 RVA: 0x0023C94D File Offset: 0x0023AB4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TakeChapterRewardScRsp> Parser
		{
			get
			{
				return TakeChapterRewardScRsp._parser;
			}
		}

		// Token: 0x17003C5B RID: 15451
		// (get) Token: 0x0600D6AF RID: 54959 RVA: 0x0023C954 File Offset: 0x0023AB54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TakeChapterRewardScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003C5C RID: 15452
		// (get) Token: 0x0600D6B0 RID: 54960 RVA: 0x0023C966 File Offset: 0x0023AB66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TakeChapterRewardScRsp.Descriptor;
			}
		}

		// Token: 0x0600D6B1 RID: 54961 RVA: 0x0023C96D File Offset: 0x0023AB6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeChapterRewardScRsp()
		{
		}

		// Token: 0x0600D6B2 RID: 54962 RVA: 0x0023C975 File Offset: 0x0023AB75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeChapterRewardScRsp(TakeChapterRewardScRsp other) : this()
		{
			this.fNIGBOMHLBE_ = other.fNIGBOMHLBE_;
			this.cIGPMMBDEJD_ = other.cIGPMMBDEJD_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D6B3 RID: 54963 RVA: 0x0023C9B2 File Offset: 0x0023ABB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeChapterRewardScRsp Clone()
		{
			return new TakeChapterRewardScRsp(this);
		}

		// Token: 0x17003C5D RID: 15453
		// (get) Token: 0x0600D6B4 RID: 54964 RVA: 0x0023C9BA File Offset: 0x0023ABBA
		// (set) Token: 0x0600D6B5 RID: 54965 RVA: 0x0023C9C2 File Offset: 0x0023ABC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint FNIGBOMHLBE
		{
			get
			{
				return this.fNIGBOMHLBE_;
			}
			set
			{
				this.fNIGBOMHLBE_ = value;
			}
		}

		// Token: 0x17003C5E RID: 15454
		// (get) Token: 0x0600D6B6 RID: 54966 RVA: 0x0023C9CB File Offset: 0x0023ABCB
		// (set) Token: 0x0600D6B7 RID: 54967 RVA: 0x0023C9D3 File Offset: 0x0023ABD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CIGPMMBDEJD
		{
			get
			{
				return this.cIGPMMBDEJD_;
			}
			set
			{
				this.cIGPMMBDEJD_ = value;
			}
		}

		// Token: 0x17003C5F RID: 15455
		// (get) Token: 0x0600D6B8 RID: 54968 RVA: 0x0023C9DC File Offset: 0x0023ABDC
		// (set) Token: 0x0600D6B9 RID: 54969 RVA: 0x0023C9E4 File Offset: 0x0023ABE4
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

		// Token: 0x0600D6BA RID: 54970 RVA: 0x0023C9ED File Offset: 0x0023ABED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TakeChapterRewardScRsp);
		}

		// Token: 0x0600D6BB RID: 54971 RVA: 0x0023C9FC File Offset: 0x0023ABFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TakeChapterRewardScRsp other)
		{
			return other != null && (other == this || (this.FNIGBOMHLBE == other.FNIGBOMHLBE && this.CIGPMMBDEJD == other.CIGPMMBDEJD && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D6BC RID: 54972 RVA: 0x0023CA58 File Offset: 0x0023AC58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FNIGBOMHLBE != 0U)
			{
				num ^= this.FNIGBOMHLBE.GetHashCode();
			}
			if (this.CIGPMMBDEJD != 0U)
			{
				num ^= this.CIGPMMBDEJD.GetHashCode();
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

		// Token: 0x0600D6BD RID: 54973 RVA: 0x0023CAC9 File Offset: 0x0023ACC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D6BE RID: 54974 RVA: 0x0023CAD1 File Offset: 0x0023ACD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D6BF RID: 54975 RVA: 0x0023CADC File Offset: 0x0023ACDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Retcode);
			}
			if (this.CIGPMMBDEJD != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.CIGPMMBDEJD);
			}
			if (this.FNIGBOMHLBE != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.FNIGBOMHLBE);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D6C0 RID: 54976 RVA: 0x0023CB54 File Offset: 0x0023AD54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FNIGBOMHLBE != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FNIGBOMHLBE);
			}
			if (this.CIGPMMBDEJD != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CIGPMMBDEJD);
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

		// Token: 0x0600D6C1 RID: 54977 RVA: 0x0023CBC4 File Offset: 0x0023ADC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TakeChapterRewardScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FNIGBOMHLBE != 0U)
			{
				this.FNIGBOMHLBE = other.FNIGBOMHLBE;
			}
			if (other.CIGPMMBDEJD != 0U)
			{
				this.CIGPMMBDEJD = other.CIGPMMBDEJD;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D6C2 RID: 54978 RVA: 0x0023CC28 File Offset: 0x0023AE28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D6C3 RID: 54979 RVA: 0x0023CC34 File Offset: 0x0023AE34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 64U)
					{
						if (num != 72U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.FNIGBOMHLBE = input.ReadUInt32();
						}
					}
					else
					{
						this.CIGPMMBDEJD = input.ReadUInt32();
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040055B6 RID: 21942
		private static readonly MessageParser<TakeChapterRewardScRsp> _parser = new MessageParser<TakeChapterRewardScRsp>(() => new TakeChapterRewardScRsp());

		// Token: 0x040055B7 RID: 21943
		private UnknownFieldSet _unknownFields;

		// Token: 0x040055B8 RID: 21944
		public const int FNIGBOMHLBEFieldNumber = 9;

		// Token: 0x040055B9 RID: 21945
		private uint fNIGBOMHLBE_;

		// Token: 0x040055BA RID: 21946
		public const int CIGPMMBDEJDFieldNumber = 8;

		// Token: 0x040055BB RID: 21947
		private uint cIGPMMBDEJD_;

		// Token: 0x040055BC RID: 21948
		public const int RetcodeFieldNumber = 3;

		// Token: 0x040055BD RID: 21949
		private uint retcode_;
	}
}
