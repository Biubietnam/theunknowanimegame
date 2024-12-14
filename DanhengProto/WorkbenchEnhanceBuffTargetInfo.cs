using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200143B RID: 5179
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class WorkbenchEnhanceBuffTargetInfo : IMessage<WorkbenchEnhanceBuffTargetInfo>, IMessage, IEquatable<WorkbenchEnhanceBuffTargetInfo>, IDeepCloneable<WorkbenchEnhanceBuffTargetInfo>, IBufferMessage
	{
		// Token: 0x170040DB RID: 16603
		// (get) Token: 0x0600E70D RID: 59149 RVA: 0x00266109 File Offset: 0x00264309
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<WorkbenchEnhanceBuffTargetInfo> Parser
		{
			get
			{
				return WorkbenchEnhanceBuffTargetInfo._parser;
			}
		}

		// Token: 0x170040DC RID: 16604
		// (get) Token: 0x0600E70E RID: 59150 RVA: 0x00266110 File Offset: 0x00264310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return WorkbenchEnhanceBuffTargetInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170040DD RID: 16605
		// (get) Token: 0x0600E70F RID: 59151 RVA: 0x00266122 File Offset: 0x00264322
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WorkbenchEnhanceBuffTargetInfo.Descriptor;
			}
		}

		// Token: 0x0600E710 RID: 59152 RVA: 0x00266129 File Offset: 0x00264329
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorkbenchEnhanceBuffTargetInfo()
		{
		}

		// Token: 0x0600E711 RID: 59153 RVA: 0x00266131 File Offset: 0x00264331
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorkbenchEnhanceBuffTargetInfo(WorkbenchEnhanceBuffTargetInfo other) : this()
		{
			this.targetBuffId_ = other.targetBuffId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E712 RID: 59154 RVA: 0x00266156 File Offset: 0x00264356
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorkbenchEnhanceBuffTargetInfo Clone()
		{
			return new WorkbenchEnhanceBuffTargetInfo(this);
		}

		// Token: 0x170040DE RID: 16606
		// (get) Token: 0x0600E713 RID: 59155 RVA: 0x0026615E File Offset: 0x0026435E
		// (set) Token: 0x0600E714 RID: 59156 RVA: 0x00266166 File Offset: 0x00264366
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint TargetBuffId
		{
			get
			{
				return this.targetBuffId_;
			}
			set
			{
				this.targetBuffId_ = value;
			}
		}

		// Token: 0x0600E715 RID: 59157 RVA: 0x0026616F File Offset: 0x0026436F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WorkbenchEnhanceBuffTargetInfo);
		}

		// Token: 0x0600E716 RID: 59158 RVA: 0x0026617D File Offset: 0x0026437D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WorkbenchEnhanceBuffTargetInfo other)
		{
			return other != null && (other == this || (this.TargetBuffId == other.TargetBuffId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E717 RID: 59159 RVA: 0x002661AC File Offset: 0x002643AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TargetBuffId != 0U)
			{
				num ^= this.TargetBuffId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E718 RID: 59160 RVA: 0x002661EB File Offset: 0x002643EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E719 RID: 59161 RVA: 0x002661F3 File Offset: 0x002643F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E71A RID: 59162 RVA: 0x002661FC File Offset: 0x002643FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TargetBuffId != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.TargetBuffId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E71B RID: 59163 RVA: 0x00266230 File Offset: 0x00264430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TargetBuffId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TargetBuffId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E71C RID: 59164 RVA: 0x0026626E File Offset: 0x0026446E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WorkbenchEnhanceBuffTargetInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TargetBuffId != 0U)
			{
				this.TargetBuffId = other.TargetBuffId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E71D RID: 59165 RVA: 0x0026629F File Offset: 0x0026449F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E71E RID: 59166 RVA: 0x002662A8 File Offset: 0x002644A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.TargetBuffId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04005BAD RID: 23469
		private static readonly MessageParser<WorkbenchEnhanceBuffTargetInfo> _parser = new MessageParser<WorkbenchEnhanceBuffTargetInfo>(() => new WorkbenchEnhanceBuffTargetInfo());

		// Token: 0x04005BAE RID: 23470
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005BAF RID: 23471
		public const int TargetBuffIdFieldNumber = 6;

		// Token: 0x04005BB0 RID: 23472
		private uint targetBuffId_;
	}
}
