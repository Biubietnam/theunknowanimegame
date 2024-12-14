using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E65 RID: 3685
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueCommonRemoveMiracle : IMessage<RogueCommonRemoveMiracle>, IMessage, IEquatable<RogueCommonRemoveMiracle>, IDeepCloneable<RogueCommonRemoveMiracle>, IBufferMessage
	{
		// Token: 0x17002E62 RID: 11874
		// (get) Token: 0x0600A458 RID: 42072 RVA: 0x001B9AE4 File Offset: 0x001B7CE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueCommonRemoveMiracle> Parser
		{
			get
			{
				return RogueCommonRemoveMiracle._parser;
			}
		}

		// Token: 0x17002E63 RID: 11875
		// (get) Token: 0x0600A459 RID: 42073 RVA: 0x001B9AEB File Offset: 0x001B7CEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueCommonRemoveMiracleReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002E64 RID: 11876
		// (get) Token: 0x0600A45A RID: 42074 RVA: 0x001B9AFD File Offset: 0x001B7CFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueCommonRemoveMiracle.Descriptor;
			}
		}

		// Token: 0x0600A45B RID: 42075 RVA: 0x001B9B04 File Offset: 0x001B7D04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonRemoveMiracle()
		{
		}

		// Token: 0x0600A45C RID: 42076 RVA: 0x001B9B0C File Offset: 0x001B7D0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonRemoveMiracle(RogueCommonRemoveMiracle other) : this()
		{
			this.miracleId_ = other.miracleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A45D RID: 42077 RVA: 0x001B9B31 File Offset: 0x001B7D31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonRemoveMiracle Clone()
		{
			return new RogueCommonRemoveMiracle(this);
		}

		// Token: 0x17002E65 RID: 11877
		// (get) Token: 0x0600A45E RID: 42078 RVA: 0x001B9B39 File Offset: 0x001B7D39
		// (set) Token: 0x0600A45F RID: 42079 RVA: 0x001B9B41 File Offset: 0x001B7D41
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

		// Token: 0x0600A460 RID: 42080 RVA: 0x001B9B4A File Offset: 0x001B7D4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueCommonRemoveMiracle);
		}

		// Token: 0x0600A461 RID: 42081 RVA: 0x001B9B58 File Offset: 0x001B7D58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueCommonRemoveMiracle other)
		{
			return other != null && (other == this || (this.MiracleId == other.MiracleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A462 RID: 42082 RVA: 0x001B9B88 File Offset: 0x001B7D88
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

		// Token: 0x0600A463 RID: 42083 RVA: 0x001B9BC7 File Offset: 0x001B7DC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A464 RID: 42084 RVA: 0x001B9BCF File Offset: 0x001B7DCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A465 RID: 42085 RVA: 0x001B9BD8 File Offset: 0x001B7DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MiracleId != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.MiracleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A466 RID: 42086 RVA: 0x001B9C0C File Offset: 0x001B7E0C
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

		// Token: 0x0600A467 RID: 42087 RVA: 0x001B9C4A File Offset: 0x001B7E4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueCommonRemoveMiracle other)
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

		// Token: 0x0600A468 RID: 42088 RVA: 0x001B9C7B File Offset: 0x001B7E7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A469 RID: 42089 RVA: 0x001B9C84 File Offset: 0x001B7E84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.MiracleId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400432A RID: 17194
		private static readonly MessageParser<RogueCommonRemoveMiracle> _parser = new MessageParser<RogueCommonRemoveMiracle>(() => new RogueCommonRemoveMiracle());

		// Token: 0x0400432B RID: 17195
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400432C RID: 17196
		public const int MiracleIdFieldNumber = 10;

		// Token: 0x0400432D RID: 17197
		private uint miracleId_;
	}
}
