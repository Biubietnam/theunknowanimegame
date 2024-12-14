using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001377 RID: 4983
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TravelBrochureGetPasterScNotify : IMessage<TravelBrochureGetPasterScNotify>, IMessage, IEquatable<TravelBrochureGetPasterScNotify>, IDeepCloneable<TravelBrochureGetPasterScNotify>, IBufferMessage
	{
		// Token: 0x17003E70 RID: 15984
		// (get) Token: 0x0600DE4C RID: 56908 RVA: 0x0024FC9D File Offset: 0x0024DE9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TravelBrochureGetPasterScNotify> Parser
		{
			get
			{
				return TravelBrochureGetPasterScNotify._parser;
			}
		}

		// Token: 0x17003E71 RID: 15985
		// (get) Token: 0x0600DE4D RID: 56909 RVA: 0x0024FCA4 File Offset: 0x0024DEA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TravelBrochureGetPasterScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003E72 RID: 15986
		// (get) Token: 0x0600DE4E RID: 56910 RVA: 0x0024FCB6 File Offset: 0x0024DEB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TravelBrochureGetPasterScNotify.Descriptor;
			}
		}

		// Token: 0x0600DE4F RID: 56911 RVA: 0x0024FCBD File Offset: 0x0024DEBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TravelBrochureGetPasterScNotify()
		{
		}

		// Token: 0x0600DE50 RID: 56912 RVA: 0x0024FCC5 File Offset: 0x0024DEC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TravelBrochureGetPasterScNotify(TravelBrochureGetPasterScNotify other) : this()
		{
			this.jIJIEKNBNPE_ = other.jIJIEKNBNPE_;
			this.num_ = other.num_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DE51 RID: 56913 RVA: 0x0024FCF6 File Offset: 0x0024DEF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TravelBrochureGetPasterScNotify Clone()
		{
			return new TravelBrochureGetPasterScNotify(this);
		}

		// Token: 0x17003E73 RID: 15987
		// (get) Token: 0x0600DE52 RID: 56914 RVA: 0x0024FCFE File Offset: 0x0024DEFE
		// (set) Token: 0x0600DE53 RID: 56915 RVA: 0x0024FD06 File Offset: 0x0024DF06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint JIJIEKNBNPE
		{
			get
			{
				return this.jIJIEKNBNPE_;
			}
			set
			{
				this.jIJIEKNBNPE_ = value;
			}
		}

		// Token: 0x17003E74 RID: 15988
		// (get) Token: 0x0600DE54 RID: 56916 RVA: 0x0024FD0F File Offset: 0x0024DF0F
		// (set) Token: 0x0600DE55 RID: 56917 RVA: 0x0024FD17 File Offset: 0x0024DF17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Num
		{
			get
			{
				return this.num_;
			}
			set
			{
				this.num_ = value;
			}
		}

		// Token: 0x0600DE56 RID: 56918 RVA: 0x0024FD20 File Offset: 0x0024DF20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TravelBrochureGetPasterScNotify);
		}

		// Token: 0x0600DE57 RID: 56919 RVA: 0x0024FD2E File Offset: 0x0024DF2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TravelBrochureGetPasterScNotify other)
		{
			return other != null && (other == this || (this.JIJIEKNBNPE == other.JIJIEKNBNPE && this.Num == other.Num && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DE58 RID: 56920 RVA: 0x0024FD6C File Offset: 0x0024DF6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.JIJIEKNBNPE != 0U)
			{
				num ^= this.JIJIEKNBNPE.GetHashCode();
			}
			if (this.Num != 0U)
			{
				num ^= this.Num.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DE59 RID: 56921 RVA: 0x0024FDC4 File Offset: 0x0024DFC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600DE5A RID: 56922 RVA: 0x0024FDCC File Offset: 0x0024DFCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DE5B RID: 56923 RVA: 0x0024FDD8 File Offset: 0x0024DFD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.JIJIEKNBNPE != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.JIJIEKNBNPE);
			}
			if (this.Num != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Num);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DE5C RID: 56924 RVA: 0x0024FE30 File Offset: 0x0024E030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.JIJIEKNBNPE != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.JIJIEKNBNPE);
			}
			if (this.Num != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Num);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DE5D RID: 56925 RVA: 0x0024FE88 File Offset: 0x0024E088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TravelBrochureGetPasterScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.JIJIEKNBNPE != 0U)
			{
				this.JIJIEKNBNPE = other.JIJIEKNBNPE;
			}
			if (other.Num != 0U)
			{
				this.Num = other.Num;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DE5E RID: 56926 RVA: 0x0024FED8 File Offset: 0x0024E0D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DE5F RID: 56927 RVA: 0x0024FEE4 File Offset: 0x0024E0E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Num = input.ReadUInt32();
					}
				}
				else
				{
					this.JIJIEKNBNPE = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400586A RID: 22634
		private static readonly MessageParser<TravelBrochureGetPasterScNotify> _parser = new MessageParser<TravelBrochureGetPasterScNotify>(() => new TravelBrochureGetPasterScNotify());

		// Token: 0x0400586B RID: 22635
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400586C RID: 22636
		public const int JIJIEKNBNPEFieldNumber = 1;

		// Token: 0x0400586D RID: 22637
		private uint jIJIEKNBNPE_;

		// Token: 0x0400586E RID: 22638
		public const int NumFieldNumber = 2;

		// Token: 0x0400586F RID: 22639
		private uint num_;
	}
}
