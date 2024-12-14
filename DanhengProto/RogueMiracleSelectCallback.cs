using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F41 RID: 3905
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueMiracleSelectCallback : IMessage<RogueMiracleSelectCallback>, IMessage, IEquatable<RogueMiracleSelectCallback>, IDeepCloneable<RogueMiracleSelectCallback>, IBufferMessage
	{
		// Token: 0x1700312E RID: 12590
		// (get) Token: 0x0600AE45 RID: 44613 RVA: 0x001D4BC7 File Offset: 0x001D2DC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueMiracleSelectCallback> Parser
		{
			get
			{
				return RogueMiracleSelectCallback._parser;
			}
		}

		// Token: 0x1700312F RID: 12591
		// (get) Token: 0x0600AE46 RID: 44614 RVA: 0x001D4BCE File Offset: 0x001D2DCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueMiracleSelectCallbackReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003130 RID: 12592
		// (get) Token: 0x0600AE47 RID: 44615 RVA: 0x001D4BE0 File Offset: 0x001D2DE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueMiracleSelectCallback.Descriptor;
			}
		}

		// Token: 0x0600AE48 RID: 44616 RVA: 0x001D4BE7 File Offset: 0x001D2DE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMiracleSelectCallback()
		{
		}

		// Token: 0x0600AE49 RID: 44617 RVA: 0x001D4BEF File Offset: 0x001D2DEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMiracleSelectCallback(RogueMiracleSelectCallback other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AE4A RID: 44618 RVA: 0x001D4C08 File Offset: 0x001D2E08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMiracleSelectCallback Clone()
		{
			return new RogueMiracleSelectCallback(this);
		}

		// Token: 0x0600AE4B RID: 44619 RVA: 0x001D4C10 File Offset: 0x001D2E10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueMiracleSelectCallback);
		}

		// Token: 0x0600AE4C RID: 44620 RVA: 0x001D4C1E File Offset: 0x001D2E1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueMiracleSelectCallback other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600AE4D RID: 44621 RVA: 0x001D4C3C File Offset: 0x001D2E3C
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

		// Token: 0x0600AE4E RID: 44622 RVA: 0x001D4C62 File Offset: 0x001D2E62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AE4F RID: 44623 RVA: 0x001D4C6A File Offset: 0x001D2E6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AE50 RID: 44624 RVA: 0x001D4C73 File Offset: 0x001D2E73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AE51 RID: 44625 RVA: 0x001D4C8C File Offset: 0x001D2E8C
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

		// Token: 0x0600AE52 RID: 44626 RVA: 0x001D4CB2 File Offset: 0x001D2EB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueMiracleSelectCallback other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AE53 RID: 44627 RVA: 0x001D4CCF File Offset: 0x001D2ECF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AE54 RID: 44628 RVA: 0x001D4CD8 File Offset: 0x001D2ED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040046F5 RID: 18165
		private static readonly MessageParser<RogueMiracleSelectCallback> _parser = new MessageParser<RogueMiracleSelectCallback>(() => new RogueMiracleSelectCallback());

		// Token: 0x040046F6 RID: 18166
		private UnknownFieldSet _unknownFields;
	}
}
