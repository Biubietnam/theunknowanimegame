using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020003EF RID: 1007
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ECHPHBKEOLG : IMessage<ECHPHBKEOLG>, IMessage, IEquatable<ECHPHBKEOLG>, IDeepCloneable<ECHPHBKEOLG>, IBufferMessage
	{
		// Token: 0x17000CDA RID: 3290
		// (get) Token: 0x06002CD4 RID: 11476 RVA: 0x0007C346 File Offset: 0x0007A546
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ECHPHBKEOLG> Parser
		{
			get
			{
				return ECHPHBKEOLG._parser;
			}
		}

		// Token: 0x17000CDB RID: 3291
		// (get) Token: 0x06002CD5 RID: 11477 RVA: 0x0007C34D File Offset: 0x0007A54D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ECHPHBKEOLGReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000CDC RID: 3292
		// (get) Token: 0x06002CD6 RID: 11478 RVA: 0x0007C35F File Offset: 0x0007A55F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ECHPHBKEOLG.Descriptor;
			}
		}

		// Token: 0x06002CD7 RID: 11479 RVA: 0x0007C366 File Offset: 0x0007A566
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ECHPHBKEOLG()
		{
		}

		// Token: 0x06002CD8 RID: 11480 RVA: 0x0007C36E File Offset: 0x0007A56E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ECHPHBKEOLG(ECHPHBKEOLG other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002CD9 RID: 11481 RVA: 0x0007C387 File Offset: 0x0007A587
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ECHPHBKEOLG Clone()
		{
			return new ECHPHBKEOLG(this);
		}

		// Token: 0x06002CDA RID: 11482 RVA: 0x0007C38F File Offset: 0x0007A58F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ECHPHBKEOLG);
		}

		// Token: 0x06002CDB RID: 11483 RVA: 0x0007C39D File Offset: 0x0007A59D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ECHPHBKEOLG other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06002CDC RID: 11484 RVA: 0x0007C3BC File Offset: 0x0007A5BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002CDD RID: 11485 RVA: 0x0007C3E2 File Offset: 0x0007A5E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002CDE RID: 11486 RVA: 0x0007C3EA File Offset: 0x0007A5EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002CDF RID: 11487 RVA: 0x0007C3F3 File Offset: 0x0007A5F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002CE0 RID: 11488 RVA: 0x0007C40C File Offset: 0x0007A60C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002CE1 RID: 11489 RVA: 0x0007C432 File Offset: 0x0007A632
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ECHPHBKEOLG other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002CE2 RID: 11490 RVA: 0x0007C44F File Offset: 0x0007A64F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002CE3 RID: 11491 RVA: 0x0007C458 File Offset: 0x0007A658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001212 RID: 4626
		private static readonly MessageParser<ECHPHBKEOLG> _parser = new MessageParser<ECHPHBKEOLG>(() => new ECHPHBKEOLG());

		// Token: 0x04001213 RID: 4627
		private UnknownFieldSet _unknownFields;
	}
}
