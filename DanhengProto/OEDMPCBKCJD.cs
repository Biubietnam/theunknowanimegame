using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C49 RID: 3145
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class OEDMPCBKCJD : IMessage<OEDMPCBKCJD>, IMessage, IEquatable<OEDMPCBKCJD>, IDeepCloneable<OEDMPCBKCJD>, IBufferMessage
	{
		// Token: 0x17002730 RID: 10032
		// (get) Token: 0x06008B8E RID: 35726 RVA: 0x00170CF4 File Offset: 0x0016EEF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OEDMPCBKCJD> Parser
		{
			get
			{
				return OEDMPCBKCJD._parser;
			}
		}

		// Token: 0x17002731 RID: 10033
		// (get) Token: 0x06008B8F RID: 35727 RVA: 0x00170CFB File Offset: 0x0016EEFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return OEDMPCBKCJDReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002732 RID: 10034
		// (get) Token: 0x06008B90 RID: 35728 RVA: 0x00170D0D File Offset: 0x0016EF0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OEDMPCBKCJD.Descriptor;
			}
		}

		// Token: 0x06008B91 RID: 35729 RVA: 0x00170D14 File Offset: 0x0016EF14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OEDMPCBKCJD()
		{
		}

		// Token: 0x06008B92 RID: 35730 RVA: 0x00170D1C File Offset: 0x0016EF1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OEDMPCBKCJD(OEDMPCBKCJD other) : this()
		{
			this.mapId_ = other.mapId_;
			this.iFLCOPDJNEP_ = other.iFLCOPDJNEP_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008B93 RID: 35731 RVA: 0x00170D4D File Offset: 0x0016EF4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OEDMPCBKCJD Clone()
		{
			return new OEDMPCBKCJD(this);
		}

		// Token: 0x17002733 RID: 10035
		// (get) Token: 0x06008B94 RID: 35732 RVA: 0x00170D55 File Offset: 0x0016EF55
		// (set) Token: 0x06008B95 RID: 35733 RVA: 0x00170D5D File Offset: 0x0016EF5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MapId
		{
			get
			{
				return this.mapId_;
			}
			set
			{
				this.mapId_ = value;
			}
		}

		// Token: 0x17002734 RID: 10036
		// (get) Token: 0x06008B96 RID: 35734 RVA: 0x00170D66 File Offset: 0x0016EF66
		// (set) Token: 0x06008B97 RID: 35735 RVA: 0x00170D6E File Offset: 0x0016EF6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint IFLCOPDJNEP
		{
			get
			{
				return this.iFLCOPDJNEP_;
			}
			set
			{
				this.iFLCOPDJNEP_ = value;
			}
		}

		// Token: 0x06008B98 RID: 35736 RVA: 0x00170D77 File Offset: 0x0016EF77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OEDMPCBKCJD);
		}

		// Token: 0x06008B99 RID: 35737 RVA: 0x00170D85 File Offset: 0x0016EF85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OEDMPCBKCJD other)
		{
			return other != null && (other == this || (this.MapId == other.MapId && this.IFLCOPDJNEP == other.IFLCOPDJNEP && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008B9A RID: 35738 RVA: 0x00170DC4 File Offset: 0x0016EFC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MapId != 0U)
			{
				num ^= this.MapId.GetHashCode();
			}
			if (this.IFLCOPDJNEP != 0U)
			{
				num ^= this.IFLCOPDJNEP.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008B9B RID: 35739 RVA: 0x00170E1C File Offset: 0x0016F01C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008B9C RID: 35740 RVA: 0x00170E24 File Offset: 0x0016F024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008B9D RID: 35741 RVA: 0x00170E30 File Offset: 0x0016F030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IFLCOPDJNEP != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.IFLCOPDJNEP);
			}
			if (this.MapId != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.MapId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008B9E RID: 35742 RVA: 0x00170E8C File Offset: 0x0016F08C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MapId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MapId);
			}
			if (this.IFLCOPDJNEP != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.IFLCOPDJNEP);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008B9F RID: 35743 RVA: 0x00170EE4 File Offset: 0x0016F0E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OEDMPCBKCJD other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MapId != 0U)
			{
				this.MapId = other.MapId;
			}
			if (other.IFLCOPDJNEP != 0U)
			{
				this.IFLCOPDJNEP = other.IFLCOPDJNEP;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008BA0 RID: 35744 RVA: 0x00170F34 File Offset: 0x0016F134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008BA1 RID: 35745 RVA: 0x00170F40 File Offset: 0x0016F140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.MapId = input.ReadUInt32();
					}
				}
				else
				{
					this.IFLCOPDJNEP = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003594 RID: 13716
		private static readonly MessageParser<OEDMPCBKCJD> _parser = new MessageParser<OEDMPCBKCJD>(() => new OEDMPCBKCJD());

		// Token: 0x04003595 RID: 13717
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003596 RID: 13718
		public const int MapIdFieldNumber = 13;

		// Token: 0x04003597 RID: 13719
		private uint mapId_;

		// Token: 0x04003598 RID: 13720
		public const int IFLCOPDJNEPFieldNumber = 3;

		// Token: 0x04003599 RID: 13721
		private uint iFLCOPDJNEP_;
	}
}
