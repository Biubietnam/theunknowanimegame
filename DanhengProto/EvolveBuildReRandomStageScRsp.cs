using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020004B7 RID: 1207
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EvolveBuildReRandomStageScRsp : IMessage<EvolveBuildReRandomStageScRsp>, IMessage, IEquatable<EvolveBuildReRandomStageScRsp>, IDeepCloneable<EvolveBuildReRandomStageScRsp>, IBufferMessage
	{
		// Token: 0x17000F69 RID: 3945
		// (get) Token: 0x060035F2 RID: 13810 RVA: 0x000947EB File Offset: 0x000929EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EvolveBuildReRandomStageScRsp> Parser
		{
			get
			{
				return EvolveBuildReRandomStageScRsp._parser;
			}
		}

		// Token: 0x17000F6A RID: 3946
		// (get) Token: 0x060035F3 RID: 13811 RVA: 0x000947F2 File Offset: 0x000929F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EvolveBuildReRandomStageScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000F6B RID: 3947
		// (get) Token: 0x060035F4 RID: 13812 RVA: 0x00094804 File Offset: 0x00092A04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EvolveBuildReRandomStageScRsp.Descriptor;
			}
		}

		// Token: 0x060035F5 RID: 13813 RVA: 0x0009480B File Offset: 0x00092A0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildReRandomStageScRsp()
		{
		}

		// Token: 0x060035F6 RID: 13814 RVA: 0x00094814 File Offset: 0x00092A14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildReRandomStageScRsp(EvolveBuildReRandomStageScRsp other) : this()
		{
			this.kPEMIFNCMPJ_ = ((other.kPEMIFNCMPJ_ != null) ? other.kPEMIFNCMPJ_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060035F7 RID: 13815 RVA: 0x00094860 File Offset: 0x00092A60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildReRandomStageScRsp Clone()
		{
			return new EvolveBuildReRandomStageScRsp(this);
		}

		// Token: 0x17000F6C RID: 3948
		// (get) Token: 0x060035F8 RID: 13816 RVA: 0x00094868 File Offset: 0x00092A68
		// (set) Token: 0x060035F9 RID: 13817 RVA: 0x00094870 File Offset: 0x00092A70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LCINGIMGEEM KPEMIFNCMPJ
		{
			get
			{
				return this.kPEMIFNCMPJ_;
			}
			set
			{
				this.kPEMIFNCMPJ_ = value;
			}
		}

		// Token: 0x17000F6D RID: 3949
		// (get) Token: 0x060035FA RID: 13818 RVA: 0x00094879 File Offset: 0x00092A79
		// (set) Token: 0x060035FB RID: 13819 RVA: 0x00094881 File Offset: 0x00092A81
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

		// Token: 0x060035FC RID: 13820 RVA: 0x0009488A File Offset: 0x00092A8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EvolveBuildReRandomStageScRsp);
		}

		// Token: 0x060035FD RID: 13821 RVA: 0x00094898 File Offset: 0x00092A98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EvolveBuildReRandomStageScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.KPEMIFNCMPJ, other.KPEMIFNCMPJ) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060035FE RID: 13822 RVA: 0x000948E8 File Offset: 0x00092AE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.kPEMIFNCMPJ_ != null)
			{
				num ^= this.KPEMIFNCMPJ.GetHashCode();
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

		// Token: 0x060035FF RID: 13823 RVA: 0x0009493D File Offset: 0x00092B3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003600 RID: 13824 RVA: 0x00094945 File Offset: 0x00092B45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003601 RID: 13825 RVA: 0x00094950 File Offset: 0x00092B50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Retcode);
			}
			if (this.kPEMIFNCMPJ_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.KPEMIFNCMPJ);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003602 RID: 13826 RVA: 0x000949A8 File Offset: 0x00092BA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.kPEMIFNCMPJ_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.KPEMIFNCMPJ);
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

		// Token: 0x06003603 RID: 13827 RVA: 0x00094A00 File Offset: 0x00092C00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EvolveBuildReRandomStageScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.kPEMIFNCMPJ_ != null)
			{
				if (this.kPEMIFNCMPJ_ == null)
				{
					this.KPEMIFNCMPJ = new LCINGIMGEEM();
				}
				this.KPEMIFNCMPJ.MergeFrom(other.KPEMIFNCMPJ);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003604 RID: 13828 RVA: 0x00094A68 File Offset: 0x00092C68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003605 RID: 13829 RVA: 0x00094A74 File Offset: 0x00092C74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 34U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.kPEMIFNCMPJ_ == null)
						{
							this.KPEMIFNCMPJ = new LCINGIMGEEM();
						}
						input.ReadMessage(this.KPEMIFNCMPJ);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400157D RID: 5501
		private static readonly MessageParser<EvolveBuildReRandomStageScRsp> _parser = new MessageParser<EvolveBuildReRandomStageScRsp>(() => new EvolveBuildReRandomStageScRsp());

		// Token: 0x0400157E RID: 5502
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400157F RID: 5503
		public const int KPEMIFNCMPJFieldNumber = 4;

		// Token: 0x04001580 RID: 5504
		private LCINGIMGEEM kPEMIFNCMPJ_;

		// Token: 0x04001581 RID: 5505
		public const int RetcodeFieldNumber = 1;

		// Token: 0x04001582 RID: 5506
		private uint retcode_;
	}
}
