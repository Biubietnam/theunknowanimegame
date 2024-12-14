using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001371 RID: 4977
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TravelBrochureApplyPasterScRsp : IMessage<TravelBrochureApplyPasterScRsp>, IMessage, IEquatable<TravelBrochureApplyPasterScRsp>, IDeepCloneable<TravelBrochureApplyPasterScRsp>, IBufferMessage
	{
		// Token: 0x17003E5E RID: 15966
		// (get) Token: 0x0600DE09 RID: 56841 RVA: 0x0024F23B File Offset: 0x0024D43B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TravelBrochureApplyPasterScRsp> Parser
		{
			get
			{
				return TravelBrochureApplyPasterScRsp._parser;
			}
		}

		// Token: 0x17003E5F RID: 15967
		// (get) Token: 0x0600DE0A RID: 56842 RVA: 0x0024F242 File Offset: 0x0024D442
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TravelBrochureApplyPasterScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003E60 RID: 15968
		// (get) Token: 0x0600DE0B RID: 56843 RVA: 0x0024F254 File Offset: 0x0024D454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TravelBrochureApplyPasterScRsp.Descriptor;
			}
		}

		// Token: 0x0600DE0C RID: 56844 RVA: 0x0024F25B File Offset: 0x0024D45B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TravelBrochureApplyPasterScRsp()
		{
		}

		// Token: 0x0600DE0D RID: 56845 RVA: 0x0024F264 File Offset: 0x0024D464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TravelBrochureApplyPasterScRsp(TravelBrochureApplyPasterScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.gKAPDOCPCJM_ = ((other.gKAPDOCPCJM_ != null) ? other.gKAPDOCPCJM_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DE0E RID: 56846 RVA: 0x0024F2B0 File Offset: 0x0024D4B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TravelBrochureApplyPasterScRsp Clone()
		{
			return new TravelBrochureApplyPasterScRsp(this);
		}

		// Token: 0x17003E61 RID: 15969
		// (get) Token: 0x0600DE0F RID: 56847 RVA: 0x0024F2B8 File Offset: 0x0024D4B8
		// (set) Token: 0x0600DE10 RID: 56848 RVA: 0x0024F2C0 File Offset: 0x0024D4C0
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

		// Token: 0x17003E62 RID: 15970
		// (get) Token: 0x0600DE11 RID: 56849 RVA: 0x0024F2C9 File Offset: 0x0024D4C9
		// (set) Token: 0x0600DE12 RID: 56850 RVA: 0x0024F2D1 File Offset: 0x0024D4D1
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

		// Token: 0x0600DE13 RID: 56851 RVA: 0x0024F2DA File Offset: 0x0024D4DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TravelBrochureApplyPasterScRsp);
		}

		// Token: 0x0600DE14 RID: 56852 RVA: 0x0024F2E8 File Offset: 0x0024D4E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TravelBrochureApplyPasterScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.GKAPDOCPCJM, other.GKAPDOCPCJM) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DE15 RID: 56853 RVA: 0x0024F338 File Offset: 0x0024D538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.gKAPDOCPCJM_ != null)
			{
				num ^= this.GKAPDOCPCJM.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DE16 RID: 56854 RVA: 0x0024F38D File Offset: 0x0024D58D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600DE17 RID: 56855 RVA: 0x0024F395 File Offset: 0x0024D595
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DE18 RID: 56856 RVA: 0x0024F3A0 File Offset: 0x0024D5A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Retcode);
			}
			if (this.gKAPDOCPCJM_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.GKAPDOCPCJM);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DE19 RID: 56857 RVA: 0x0024F3FC File Offset: 0x0024D5FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.gKAPDOCPCJM_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GKAPDOCPCJM);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DE1A RID: 56858 RVA: 0x0024F454 File Offset: 0x0024D654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TravelBrochureApplyPasterScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.gKAPDOCPCJM_ != null)
			{
				if (this.gKAPDOCPCJM_ == null)
				{
					this.GKAPDOCPCJM = new KHKLKHNGDOG();
				}
				this.GKAPDOCPCJM.MergeFrom(other.GKAPDOCPCJM);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DE1B RID: 56859 RVA: 0x0024F4BC File Offset: 0x0024D6BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DE1C RID: 56860 RVA: 0x0024F4C8 File Offset: 0x0024D6C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					if (num != 50U)
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

		// Token: 0x04005853 RID: 22611
		private static readonly MessageParser<TravelBrochureApplyPasterScRsp> _parser = new MessageParser<TravelBrochureApplyPasterScRsp>(() => new TravelBrochureApplyPasterScRsp());

		// Token: 0x04005854 RID: 22612
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005855 RID: 22613
		public const int RetcodeFieldNumber = 4;

		// Token: 0x04005856 RID: 22614
		private uint retcode_;

		// Token: 0x04005857 RID: 22615
		public const int GKAPDOCPCJMFieldNumber = 6;

		// Token: 0x04005858 RID: 22616
		private KHKLKHNGDOG gKAPDOCPCJM_;
	}
}
