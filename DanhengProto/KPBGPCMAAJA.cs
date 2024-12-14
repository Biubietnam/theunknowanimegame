using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020009D1 RID: 2513
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class KPBGPCMAAJA : IMessage<KPBGPCMAAJA>, IMessage, IEquatable<KPBGPCMAAJA>, IDeepCloneable<KPBGPCMAAJA>, IBufferMessage
	{
		// Token: 0x17001F8A RID: 8074
		// (get) Token: 0x06007012 RID: 28690 RVA: 0x0012B070 File Offset: 0x00129270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<KPBGPCMAAJA> Parser
		{
			get
			{
				return KPBGPCMAAJA._parser;
			}
		}

		// Token: 0x17001F8B RID: 8075
		// (get) Token: 0x06007013 RID: 28691 RVA: 0x0012B077 File Offset: 0x00129277
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return KPBGPCMAAJAReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001F8C RID: 8076
		// (get) Token: 0x06007014 RID: 28692 RVA: 0x0012B089 File Offset: 0x00129289
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KPBGPCMAAJA.Descriptor;
			}
		}

		// Token: 0x06007015 RID: 28693 RVA: 0x0012B090 File Offset: 0x00129290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KPBGPCMAAJA()
		{
		}

		// Token: 0x06007016 RID: 28694 RVA: 0x0012B098 File Offset: 0x00129298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KPBGPCMAAJA(KPBGPCMAAJA other) : this()
		{
			this.buffId_ = other.buffId_;
			this.uniqueId_ = other.uniqueId_;
			this.cIPAGEJLFKB_ = other.cIPAGEJLFKB_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007017 RID: 28695 RVA: 0x0012B0D5 File Offset: 0x001292D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KPBGPCMAAJA Clone()
		{
			return new KPBGPCMAAJA(this);
		}

		// Token: 0x17001F8D RID: 8077
		// (get) Token: 0x06007018 RID: 28696 RVA: 0x0012B0DD File Offset: 0x001292DD
		// (set) Token: 0x06007019 RID: 28697 RVA: 0x0012B0E5 File Offset: 0x001292E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BuffId
		{
			get
			{
				return this.buffId_;
			}
			set
			{
				this.buffId_ = value;
			}
		}

		// Token: 0x17001F8E RID: 8078
		// (get) Token: 0x0600701A RID: 28698 RVA: 0x0012B0EE File Offset: 0x001292EE
		// (set) Token: 0x0600701B RID: 28699 RVA: 0x0012B0F6 File Offset: 0x001292F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ulong UniqueId
		{
			get
			{
				return this.uniqueId_;
			}
			set
			{
				this.uniqueId_ = value;
			}
		}

		// Token: 0x17001F8F RID: 8079
		// (get) Token: 0x0600701C RID: 28700 RVA: 0x0012B0FF File Offset: 0x001292FF
		// (set) Token: 0x0600701D RID: 28701 RVA: 0x0012B107 File Offset: 0x00129307
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CIPAGEJLFKB
		{
			get
			{
				return this.cIPAGEJLFKB_;
			}
			set
			{
				this.cIPAGEJLFKB_ = value;
			}
		}

		// Token: 0x0600701E RID: 28702 RVA: 0x0012B110 File Offset: 0x00129310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KPBGPCMAAJA);
		}

		// Token: 0x0600701F RID: 28703 RVA: 0x0012B120 File Offset: 0x00129320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KPBGPCMAAJA other)
		{
			return other != null && (other == this || (this.BuffId == other.BuffId && this.UniqueId == other.UniqueId && this.CIPAGEJLFKB == other.CIPAGEJLFKB && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007020 RID: 28704 RVA: 0x0012B17C File Offset: 0x0012937C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BuffId != 0U)
			{
				num ^= this.BuffId.GetHashCode();
			}
			if (this.UniqueId != 0UL)
			{
				num ^= this.UniqueId.GetHashCode();
			}
			if (this.CIPAGEJLFKB != 0U)
			{
				num ^= this.CIPAGEJLFKB.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007021 RID: 28705 RVA: 0x0012B1ED File Offset: 0x001293ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007022 RID: 28706 RVA: 0x0012B1F5 File Offset: 0x001293F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007023 RID: 28707 RVA: 0x0012B200 File Offset: 0x00129400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CIPAGEJLFKB != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.CIPAGEJLFKB);
			}
			if (this.BuffId != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.BuffId);
			}
			if (this.UniqueId != 0UL)
			{
				output.WriteRawTag(80);
				output.WriteUInt64(this.UniqueId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007024 RID: 28708 RVA: 0x0012B278 File Offset: 0x00129478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BuffId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BuffId);
			}
			if (this.UniqueId != 0UL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.UniqueId);
			}
			if (this.CIPAGEJLFKB != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CIPAGEJLFKB);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007025 RID: 28709 RVA: 0x0012B2E8 File Offset: 0x001294E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KPBGPCMAAJA other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BuffId != 0U)
			{
				this.BuffId = other.BuffId;
			}
			if (other.UniqueId != 0UL)
			{
				this.UniqueId = other.UniqueId;
			}
			if (other.CIPAGEJLFKB != 0U)
			{
				this.CIPAGEJLFKB = other.CIPAGEJLFKB;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007026 RID: 28710 RVA: 0x0012B34C File Offset: 0x0012954C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007027 RID: 28711 RVA: 0x0012B358 File Offset: 0x00129558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 72U)
					{
						if (num != 80U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.UniqueId = input.ReadUInt64();
						}
					}
					else
					{
						this.BuffId = input.ReadUInt32();
					}
				}
				else
				{
					this.CIPAGEJLFKB = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002B18 RID: 11032
		private static readonly MessageParser<KPBGPCMAAJA> _parser = new MessageParser<KPBGPCMAAJA>(() => new KPBGPCMAAJA());

		// Token: 0x04002B19 RID: 11033
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B1A RID: 11034
		public const int BuffIdFieldNumber = 9;

		// Token: 0x04002B1B RID: 11035
		private uint buffId_;

		// Token: 0x04002B1C RID: 11036
		public const int UniqueIdFieldNumber = 10;

		// Token: 0x04002B1D RID: 11037
		private ulong uniqueId_;

		// Token: 0x04002B1E RID: 11038
		public const int CIPAGEJLFKBFieldNumber = 3;

		// Token: 0x04002B1F RID: 11039
		private uint cIPAGEJLFKB_;
	}
}
