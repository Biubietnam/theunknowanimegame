using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001381 RID: 4993
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TravelBrochureRemovePasterScRsp : IMessage<TravelBrochureRemovePasterScRsp>, IMessage, IEquatable<TravelBrochureRemovePasterScRsp>, IDeepCloneable<TravelBrochureRemovePasterScRsp>, IBufferMessage
	{
		// Token: 0x17003E8D RID: 16013
		// (get) Token: 0x0600DEBD RID: 57021 RVA: 0x00250C5B File Offset: 0x0024EE5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TravelBrochureRemovePasterScRsp> Parser
		{
			get
			{
				return TravelBrochureRemovePasterScRsp._parser;
			}
		}

		// Token: 0x17003E8E RID: 16014
		// (get) Token: 0x0600DEBE RID: 57022 RVA: 0x00250C62 File Offset: 0x0024EE62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TravelBrochureRemovePasterScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003E8F RID: 16015
		// (get) Token: 0x0600DEBF RID: 57023 RVA: 0x00250C74 File Offset: 0x0024EE74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TravelBrochureRemovePasterScRsp.Descriptor;
			}
		}

		// Token: 0x0600DEC0 RID: 57024 RVA: 0x00250C7B File Offset: 0x0024EE7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TravelBrochureRemovePasterScRsp()
		{
		}

		// Token: 0x0600DEC1 RID: 57025 RVA: 0x00250C84 File Offset: 0x0024EE84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TravelBrochureRemovePasterScRsp(TravelBrochureRemovePasterScRsp other) : this()
		{
			this.gKAPDOCPCJM_ = ((other.gKAPDOCPCJM_ != null) ? other.gKAPDOCPCJM_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DEC2 RID: 57026 RVA: 0x00250CD0 File Offset: 0x0024EED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TravelBrochureRemovePasterScRsp Clone()
		{
			return new TravelBrochureRemovePasterScRsp(this);
		}

		// Token: 0x17003E90 RID: 16016
		// (get) Token: 0x0600DEC3 RID: 57027 RVA: 0x00250CD8 File Offset: 0x0024EED8
		// (set) Token: 0x0600DEC4 RID: 57028 RVA: 0x00250CE0 File Offset: 0x0024EEE0
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

		// Token: 0x17003E91 RID: 16017
		// (get) Token: 0x0600DEC5 RID: 57029 RVA: 0x00250CE9 File Offset: 0x0024EEE9
		// (set) Token: 0x0600DEC6 RID: 57030 RVA: 0x00250CF1 File Offset: 0x0024EEF1
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

		// Token: 0x0600DEC7 RID: 57031 RVA: 0x00250CFA File Offset: 0x0024EEFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TravelBrochureRemovePasterScRsp);
		}

		// Token: 0x0600DEC8 RID: 57032 RVA: 0x00250D08 File Offset: 0x0024EF08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TravelBrochureRemovePasterScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.GKAPDOCPCJM, other.GKAPDOCPCJM) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DEC9 RID: 57033 RVA: 0x00250D58 File Offset: 0x0024EF58
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

		// Token: 0x0600DECA RID: 57034 RVA: 0x00250DAD File Offset: 0x0024EFAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600DECB RID: 57035 RVA: 0x00250DB5 File Offset: 0x0024EFB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DECC RID: 57036 RVA: 0x00250DC0 File Offset: 0x0024EFC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Retcode);
			}
			if (this.gKAPDOCPCJM_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.GKAPDOCPCJM);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DECD RID: 57037 RVA: 0x00250E1C File Offset: 0x0024F01C
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

		// Token: 0x0600DECE RID: 57038 RVA: 0x00250E74 File Offset: 0x0024F074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TravelBrochureRemovePasterScRsp other)
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

		// Token: 0x0600DECF RID: 57039 RVA: 0x00250EDC File Offset: 0x0024F0DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DED0 RID: 57040 RVA: 0x00250EE8 File Offset: 0x0024F0E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 64U)
				{
					if (num != 122U)
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

		// Token: 0x0400588B RID: 22667
		private static readonly MessageParser<TravelBrochureRemovePasterScRsp> _parser = new MessageParser<TravelBrochureRemovePasterScRsp>(() => new TravelBrochureRemovePasterScRsp());

		// Token: 0x0400588C RID: 22668
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400588D RID: 22669
		public const int GKAPDOCPCJMFieldNumber = 15;

		// Token: 0x0400588E RID: 22670
		private KHKLKHNGDOG gKAPDOCPCJM_;

		// Token: 0x0400588F RID: 22671
		public const int RetcodeFieldNumber = 8;

		// Token: 0x04005890 RID: 22672
		private uint retcode_;
	}
}
