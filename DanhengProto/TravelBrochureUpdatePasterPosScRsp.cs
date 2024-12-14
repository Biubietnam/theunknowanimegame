using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001391 RID: 5009
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TravelBrochureUpdatePasterPosScRsp : IMessage<TravelBrochureUpdatePasterPosScRsp>, IMessage, IEquatable<TravelBrochureUpdatePasterPosScRsp>, IDeepCloneable<TravelBrochureUpdatePasterPosScRsp>, IBufferMessage
	{
		// Token: 0x17003EC0 RID: 16064
		// (get) Token: 0x0600DF7B RID: 57211 RVA: 0x0025296F File Offset: 0x00250B6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TravelBrochureUpdatePasterPosScRsp> Parser
		{
			get
			{
				return TravelBrochureUpdatePasterPosScRsp._parser;
			}
		}

		// Token: 0x17003EC1 RID: 16065
		// (get) Token: 0x0600DF7C RID: 57212 RVA: 0x00252976 File Offset: 0x00250B76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TravelBrochureUpdatePasterPosScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003EC2 RID: 16066
		// (get) Token: 0x0600DF7D RID: 57213 RVA: 0x00252988 File Offset: 0x00250B88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TravelBrochureUpdatePasterPosScRsp.Descriptor;
			}
		}

		// Token: 0x0600DF7E RID: 57214 RVA: 0x0025298F File Offset: 0x00250B8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TravelBrochureUpdatePasterPosScRsp()
		{
		}

		// Token: 0x0600DF7F RID: 57215 RVA: 0x00252998 File Offset: 0x00250B98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TravelBrochureUpdatePasterPosScRsp(TravelBrochureUpdatePasterPosScRsp other) : this()
		{
			this.gKAPDOCPCJM_ = ((other.gKAPDOCPCJM_ != null) ? other.gKAPDOCPCJM_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DF80 RID: 57216 RVA: 0x002529E4 File Offset: 0x00250BE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TravelBrochureUpdatePasterPosScRsp Clone()
		{
			return new TravelBrochureUpdatePasterPosScRsp(this);
		}

		// Token: 0x17003EC3 RID: 16067
		// (get) Token: 0x0600DF81 RID: 57217 RVA: 0x002529EC File Offset: 0x00250BEC
		// (set) Token: 0x0600DF82 RID: 57218 RVA: 0x002529F4 File Offset: 0x00250BF4
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

		// Token: 0x17003EC4 RID: 16068
		// (get) Token: 0x0600DF83 RID: 57219 RVA: 0x002529FD File Offset: 0x00250BFD
		// (set) Token: 0x0600DF84 RID: 57220 RVA: 0x00252A05 File Offset: 0x00250C05
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

		// Token: 0x0600DF85 RID: 57221 RVA: 0x00252A0E File Offset: 0x00250C0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TravelBrochureUpdatePasterPosScRsp);
		}

		// Token: 0x0600DF86 RID: 57222 RVA: 0x00252A1C File Offset: 0x00250C1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TravelBrochureUpdatePasterPosScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.GKAPDOCPCJM, other.GKAPDOCPCJM) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DF87 RID: 57223 RVA: 0x00252A6C File Offset: 0x00250C6C
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

		// Token: 0x0600DF88 RID: 57224 RVA: 0x00252AC1 File Offset: 0x00250CC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600DF89 RID: 57225 RVA: 0x00252AC9 File Offset: 0x00250CC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DF8A RID: 57226 RVA: 0x00252AD4 File Offset: 0x00250CD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.Retcode);
			}
			if (this.gKAPDOCPCJM_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.GKAPDOCPCJM);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DF8B RID: 57227 RVA: 0x00252B30 File Offset: 0x00250D30
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

		// Token: 0x0600DF8C RID: 57228 RVA: 0x00252B88 File Offset: 0x00250D88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TravelBrochureUpdatePasterPosScRsp other)
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

		// Token: 0x0600DF8D RID: 57229 RVA: 0x00252BF0 File Offset: 0x00250DF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DF8E RID: 57230 RVA: 0x00252BFC File Offset: 0x00250DFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 104U)
				{
					if (num != 114U)
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

		// Token: 0x040058C9 RID: 22729
		private static readonly MessageParser<TravelBrochureUpdatePasterPosScRsp> _parser = new MessageParser<TravelBrochureUpdatePasterPosScRsp>(() => new TravelBrochureUpdatePasterPosScRsp());

		// Token: 0x040058CA RID: 22730
		private UnknownFieldSet _unknownFields;

		// Token: 0x040058CB RID: 22731
		public const int GKAPDOCPCJMFieldNumber = 14;

		// Token: 0x040058CC RID: 22732
		private KHKLKHNGDOG gKAPDOCPCJM_;

		// Token: 0x040058CD RID: 22733
		public const int RetcodeFieldNumber = 13;

		// Token: 0x040058CE RID: 22734
		private uint retcode_;
	}
}
