using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F65 RID: 3941
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueReforgeFormulaSelectCallback : IMessage<RogueReforgeFormulaSelectCallback>, IMessage, IEquatable<RogueReforgeFormulaSelectCallback>, IDeepCloneable<RogueReforgeFormulaSelectCallback>, IBufferMessage
	{
		// Token: 0x1700318D RID: 12685
		// (get) Token: 0x0600AFAD RID: 44973 RVA: 0x001D803F File Offset: 0x001D623F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueReforgeFormulaSelectCallback> Parser
		{
			get
			{
				return RogueReforgeFormulaSelectCallback._parser;
			}
		}

		// Token: 0x1700318E RID: 12686
		// (get) Token: 0x0600AFAE RID: 44974 RVA: 0x001D8046 File Offset: 0x001D6246
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueReforgeFormulaSelectCallbackReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700318F RID: 12687
		// (get) Token: 0x0600AFAF RID: 44975 RVA: 0x001D8058 File Offset: 0x001D6258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueReforgeFormulaSelectCallback.Descriptor;
			}
		}

		// Token: 0x0600AFB0 RID: 44976 RVA: 0x001D805F File Offset: 0x001D625F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueReforgeFormulaSelectCallback()
		{
		}

		// Token: 0x0600AFB1 RID: 44977 RVA: 0x001D8067 File Offset: 0x001D6267
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueReforgeFormulaSelectCallback(RogueReforgeFormulaSelectCallback other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AFB2 RID: 44978 RVA: 0x001D8080 File Offset: 0x001D6280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueReforgeFormulaSelectCallback Clone()
		{
			return new RogueReforgeFormulaSelectCallback(this);
		}

		// Token: 0x0600AFB3 RID: 44979 RVA: 0x001D8088 File Offset: 0x001D6288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueReforgeFormulaSelectCallback);
		}

		// Token: 0x0600AFB4 RID: 44980 RVA: 0x001D8096 File Offset: 0x001D6296
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueReforgeFormulaSelectCallback other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600AFB5 RID: 44981 RVA: 0x001D80B4 File Offset: 0x001D62B4
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

		// Token: 0x0600AFB6 RID: 44982 RVA: 0x001D80DA File Offset: 0x001D62DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AFB7 RID: 44983 RVA: 0x001D80E2 File Offset: 0x001D62E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AFB8 RID: 44984 RVA: 0x001D80EB File Offset: 0x001D62EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AFB9 RID: 44985 RVA: 0x001D8104 File Offset: 0x001D6304
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

		// Token: 0x0600AFBA RID: 44986 RVA: 0x001D812A File Offset: 0x001D632A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueReforgeFormulaSelectCallback other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AFBB RID: 44987 RVA: 0x001D8147 File Offset: 0x001D6347
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AFBC RID: 44988 RVA: 0x001D8150 File Offset: 0x001D6350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004775 RID: 18293
		private static readonly MessageParser<RogueReforgeFormulaSelectCallback> _parser = new MessageParser<RogueReforgeFormulaSelectCallback>(() => new RogueReforgeFormulaSelectCallback());

		// Token: 0x04004776 RID: 18294
		private UnknownFieldSet _unknownFields;
	}
}
