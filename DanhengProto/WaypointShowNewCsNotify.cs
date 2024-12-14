using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200141D RID: 5149
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class WaypointShowNewCsNotify : IMessage<WaypointShowNewCsNotify>, IMessage, IEquatable<WaypointShowNewCsNotify>, IDeepCloneable<WaypointShowNewCsNotify>, IBufferMessage
	{
		// Token: 0x1700407E RID: 16510
		// (get) Token: 0x0600E5B5 RID: 58805 RVA: 0x00262B29 File Offset: 0x00260D29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<WaypointShowNewCsNotify> Parser
		{
			get
			{
				return WaypointShowNewCsNotify._parser;
			}
		}

		// Token: 0x1700407F RID: 16511
		// (get) Token: 0x0600E5B6 RID: 58806 RVA: 0x00262B30 File Offset: 0x00260D30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return WaypointShowNewCsNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17004080 RID: 16512
		// (get) Token: 0x0600E5B7 RID: 58807 RVA: 0x00262B42 File Offset: 0x00260D42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WaypointShowNewCsNotify.Descriptor;
			}
		}

		// Token: 0x0600E5B8 RID: 58808 RVA: 0x00262B49 File Offset: 0x00260D49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WaypointShowNewCsNotify()
		{
		}

		// Token: 0x0600E5B9 RID: 58809 RVA: 0x00262B51 File Offset: 0x00260D51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WaypointShowNewCsNotify(WaypointShowNewCsNotify other) : this()
		{
			this.aEHFBJKCPMB_ = other.aEHFBJKCPMB_;
			this.cIGPMMBDEJD_ = other.cIGPMMBDEJD_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E5BA RID: 58810 RVA: 0x00262B82 File Offset: 0x00260D82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WaypointShowNewCsNotify Clone()
		{
			return new WaypointShowNewCsNotify(this);
		}

		// Token: 0x17004081 RID: 16513
		// (get) Token: 0x0600E5BB RID: 58811 RVA: 0x00262B8A File Offset: 0x00260D8A
		// (set) Token: 0x0600E5BC RID: 58812 RVA: 0x00262B92 File Offset: 0x00260D92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AEHFBJKCPMB
		{
			get
			{
				return this.aEHFBJKCPMB_;
			}
			set
			{
				this.aEHFBJKCPMB_ = value;
			}
		}

		// Token: 0x17004082 RID: 16514
		// (get) Token: 0x0600E5BD RID: 58813 RVA: 0x00262B9B File Offset: 0x00260D9B
		// (set) Token: 0x0600E5BE RID: 58814 RVA: 0x00262BA3 File Offset: 0x00260DA3
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

		// Token: 0x0600E5BF RID: 58815 RVA: 0x00262BAC File Offset: 0x00260DAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WaypointShowNewCsNotify);
		}

		// Token: 0x0600E5C0 RID: 58816 RVA: 0x00262BBA File Offset: 0x00260DBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WaypointShowNewCsNotify other)
		{
			return other != null && (other == this || (this.AEHFBJKCPMB == other.AEHFBJKCPMB && this.CIGPMMBDEJD == other.CIGPMMBDEJD && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E5C1 RID: 58817 RVA: 0x00262BF8 File Offset: 0x00260DF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AEHFBJKCPMB != 0U)
			{
				num ^= this.AEHFBJKCPMB.GetHashCode();
			}
			if (this.CIGPMMBDEJD != 0U)
			{
				num ^= this.CIGPMMBDEJD.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E5C2 RID: 58818 RVA: 0x00262C50 File Offset: 0x00260E50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E5C3 RID: 58819 RVA: 0x00262C58 File Offset: 0x00260E58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E5C4 RID: 58820 RVA: 0x00262C64 File Offset: 0x00260E64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CIGPMMBDEJD != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.CIGPMMBDEJD);
			}
			if (this.AEHFBJKCPMB != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.AEHFBJKCPMB);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E5C5 RID: 58821 RVA: 0x00262CC0 File Offset: 0x00260EC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AEHFBJKCPMB != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AEHFBJKCPMB);
			}
			if (this.CIGPMMBDEJD != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CIGPMMBDEJD);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E5C6 RID: 58822 RVA: 0x00262D18 File Offset: 0x00260F18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WaypointShowNewCsNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AEHFBJKCPMB != 0U)
			{
				this.AEHFBJKCPMB = other.AEHFBJKCPMB;
			}
			if (other.CIGPMMBDEJD != 0U)
			{
				this.CIGPMMBDEJD = other.CIGPMMBDEJD;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E5C7 RID: 58823 RVA: 0x00262D68 File Offset: 0x00260F68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E5C8 RID: 58824 RVA: 0x00262D74 File Offset: 0x00260F74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U)
				{
					if (num != 56U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.AEHFBJKCPMB = input.ReadUInt32();
					}
				}
				else
				{
					this.CIGPMMBDEJD = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04005B37 RID: 23351
		private static readonly MessageParser<WaypointShowNewCsNotify> _parser = new MessageParser<WaypointShowNewCsNotify>(() => new WaypointShowNewCsNotify());

		// Token: 0x04005B38 RID: 23352
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B39 RID: 23353
		public const int AEHFBJKCPMBFieldNumber = 7;

		// Token: 0x04005B3A RID: 23354
		private uint aEHFBJKCPMB_;

		// Token: 0x04005B3B RID: 23355
		public const int CIGPMMBDEJDFieldNumber = 6;

		// Token: 0x04005B3C RID: 23356
		private uint cIGPMMBDEJD_;
	}
}
