using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200137B RID: 4987
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TravelBrochurePageResetScRsp : IMessage<TravelBrochurePageResetScRsp>, IMessage, IEquatable<TravelBrochurePageResetScRsp>, IDeepCloneable<TravelBrochurePageResetScRsp>, IBufferMessage
	{
		// Token: 0x17003E7B RID: 15995
		// (get) Token: 0x0600DE78 RID: 56952 RVA: 0x00250249 File Offset: 0x0024E449
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TravelBrochurePageResetScRsp> Parser
		{
			get
			{
				return TravelBrochurePageResetScRsp._parser;
			}
		}

		// Token: 0x17003E7C RID: 15996
		// (get) Token: 0x0600DE79 RID: 56953 RVA: 0x00250250 File Offset: 0x0024E450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TravelBrochurePageResetScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003E7D RID: 15997
		// (get) Token: 0x0600DE7A RID: 56954 RVA: 0x00250262 File Offset: 0x0024E462
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TravelBrochurePageResetScRsp.Descriptor;
			}
		}

		// Token: 0x0600DE7B RID: 56955 RVA: 0x00250269 File Offset: 0x0024E469
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TravelBrochurePageResetScRsp()
		{
		}

		// Token: 0x0600DE7C RID: 56956 RVA: 0x00250274 File Offset: 0x0024E474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TravelBrochurePageResetScRsp(TravelBrochurePageResetScRsp other) : this()
		{
			this.gKAPDOCPCJM_ = ((other.gKAPDOCPCJM_ != null) ? other.gKAPDOCPCJM_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DE7D RID: 56957 RVA: 0x002502C0 File Offset: 0x0024E4C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TravelBrochurePageResetScRsp Clone()
		{
			return new TravelBrochurePageResetScRsp(this);
		}

		// Token: 0x17003E7E RID: 15998
		// (get) Token: 0x0600DE7E RID: 56958 RVA: 0x002502C8 File Offset: 0x0024E4C8
		// (set) Token: 0x0600DE7F RID: 56959 RVA: 0x002502D0 File Offset: 0x0024E4D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KHKLKHNGDOG GKAPDOCPCJM
		{
			get
			{
				return this.gKAPDOCPCJM_;
			}
			set
			{
				this.gKAPDOCPCJM_ = value;
			}
		}

		// Token: 0x17003E7F RID: 15999
		// (get) Token: 0x0600DE80 RID: 56960 RVA: 0x002502D9 File Offset: 0x0024E4D9
		// (set) Token: 0x0600DE81 RID: 56961 RVA: 0x002502E1 File Offset: 0x0024E4E1
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

		// Token: 0x0600DE82 RID: 56962 RVA: 0x002502EA File Offset: 0x0024E4EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TravelBrochurePageResetScRsp);
		}

		// Token: 0x0600DE83 RID: 56963 RVA: 0x002502F8 File Offset: 0x0024E4F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TravelBrochurePageResetScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.GKAPDOCPCJM, other.GKAPDOCPCJM) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DE84 RID: 56964 RVA: 0x00250348 File Offset: 0x0024E548
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.gKAPDOCPCJM_ != null)
			{
				num ^= this.GKAPDOCPCJM.GetHashCode();
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

		// Token: 0x0600DE85 RID: 56965 RVA: 0x0025039D File Offset: 0x0024E59D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600DE86 RID: 56966 RVA: 0x002503A5 File Offset: 0x0024E5A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DE87 RID: 56967 RVA: 0x002503B0 File Offset: 0x0024E5B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Retcode);
			}
			if (this.gKAPDOCPCJM_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.GKAPDOCPCJM);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DE88 RID: 56968 RVA: 0x0025040C File Offset: 0x0024E60C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.gKAPDOCPCJM_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GKAPDOCPCJM);
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

		// Token: 0x0600DE89 RID: 56969 RVA: 0x00250464 File Offset: 0x0024E664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TravelBrochurePageResetScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.gKAPDOCPCJM_ != null)
			{
				if (this.gKAPDOCPCJM_ == null)
				{
					this.GKAPDOCPCJM = new KHKLKHNGDOG();
				}
				this.GKAPDOCPCJM.MergeFrom(other.GKAPDOCPCJM);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DE8A RID: 56970 RVA: 0x002504CC File Offset: 0x0024E6CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DE8B RID: 56971 RVA: 0x002504D8 File Offset: 0x0024E6D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					if (num != 66U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.gKAPDOCPCJM_ == null)
						{
							this.GKAPDOCPCJM = new KHKLKHNGDOG();
						}
						input.ReadMessage(this.GKAPDOCPCJM);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04005876 RID: 22646
		private static readonly MessageParser<TravelBrochurePageResetScRsp> _parser = new MessageParser<TravelBrochurePageResetScRsp>(() => new TravelBrochurePageResetScRsp());

		// Token: 0x04005877 RID: 22647
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005878 RID: 22648
		public const int GKAPDOCPCJMFieldNumber = 8;

		// Token: 0x04005879 RID: 22649
		private KHKLKHNGDOG gKAPDOCPCJM_;

		// Token: 0x0400587A RID: 22650
		public const int RetcodeFieldNumber = 5;

		// Token: 0x0400587B RID: 22651
		private uint retcode_;
	}
}
