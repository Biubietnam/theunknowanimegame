using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200042B RID: 1067
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ENHHGAMEKMB : IMessage<ENHHGAMEKMB>, IMessage, IEquatable<ENHHGAMEKMB>, IDeepCloneable<ENHHGAMEKMB>, IBufferMessage
	{
		// Token: 0x17000D90 RID: 3472
		// (get) Token: 0x06002F6E RID: 12142 RVA: 0x00082E08 File Offset: 0x00081008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ENHHGAMEKMB> Parser
		{
			get
			{
				return ENHHGAMEKMB._parser;
			}
		}

		// Token: 0x17000D91 RID: 3473
		// (get) Token: 0x06002F6F RID: 12143 RVA: 0x00082E0F File Offset: 0x0008100F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ENHHGAMEKMBReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000D92 RID: 3474
		// (get) Token: 0x06002F70 RID: 12144 RVA: 0x00082E21 File Offset: 0x00081021
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ENHHGAMEKMB.Descriptor;
			}
		}

		// Token: 0x06002F71 RID: 12145 RVA: 0x00082E28 File Offset: 0x00081028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ENHHGAMEKMB()
		{
		}

		// Token: 0x06002F72 RID: 12146 RVA: 0x00082E30 File Offset: 0x00081030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ENHHGAMEKMB(ENHHGAMEKMB other) : this()
		{
			this.miracleId_ = other.miracleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002F73 RID: 12147 RVA: 0x00082E55 File Offset: 0x00081055
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ENHHGAMEKMB Clone()
		{
			return new ENHHGAMEKMB(this);
		}

		// Token: 0x17000D93 RID: 3475
		// (get) Token: 0x06002F74 RID: 12148 RVA: 0x00082E5D File Offset: 0x0008105D
		// (set) Token: 0x06002F75 RID: 12149 RVA: 0x00082E65 File Offset: 0x00081065
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MiracleId
		{
			get
			{
				return this.miracleId_;
			}
			set
			{
				this.miracleId_ = value;
			}
		}

		// Token: 0x06002F76 RID: 12150 RVA: 0x00082E6E File Offset: 0x0008106E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ENHHGAMEKMB);
		}

		// Token: 0x06002F77 RID: 12151 RVA: 0x00082E7C File Offset: 0x0008107C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ENHHGAMEKMB other)
		{
			return other != null && (other == this || (this.MiracleId == other.MiracleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002F78 RID: 12152 RVA: 0x00082EAC File Offset: 0x000810AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MiracleId != 0U)
			{
				num ^= this.MiracleId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002F79 RID: 12153 RVA: 0x00082EEB File Offset: 0x000810EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002F7A RID: 12154 RVA: 0x00082EF3 File Offset: 0x000810F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002F7B RID: 12155 RVA: 0x00082EFC File Offset: 0x000810FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MiracleId != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.MiracleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002F7C RID: 12156 RVA: 0x00082F30 File Offset: 0x00081130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MiracleId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MiracleId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002F7D RID: 12157 RVA: 0x00082F6E File Offset: 0x0008116E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ENHHGAMEKMB other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MiracleId != 0U)
			{
				this.MiracleId = other.MiracleId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002F7E RID: 12158 RVA: 0x00082F9F File Offset: 0x0008119F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002F7F RID: 12159 RVA: 0x00082FA8 File Offset: 0x000811A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.MiracleId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040012FD RID: 4861
		private static readonly MessageParser<ENHHGAMEKMB> _parser = new MessageParser<ENHHGAMEKMB>(() => new ENHHGAMEKMB());

		// Token: 0x040012FE RID: 4862
		private UnknownFieldSet _unknownFields;

		// Token: 0x040012FF RID: 4863
		public const int MiracleIdFieldNumber = 1;

		// Token: 0x04001300 RID: 4864
		private uint miracleId_;
	}
}
