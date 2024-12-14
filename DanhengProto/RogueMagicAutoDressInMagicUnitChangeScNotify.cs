using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000EAF RID: 3759
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueMagicAutoDressInMagicUnitChangeScNotify : IMessage<RogueMagicAutoDressInMagicUnitChangeScNotify>, IMessage, IEquatable<RogueMagicAutoDressInMagicUnitChangeScNotify>, IDeepCloneable<RogueMagicAutoDressInMagicUnitChangeScNotify>, IBufferMessage
	{
		// Token: 0x17002F74 RID: 12148
		// (get) Token: 0x0600A7F6 RID: 42998 RVA: 0x001C47C9 File Offset: 0x001C29C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueMagicAutoDressInMagicUnitChangeScNotify> Parser
		{
			get
			{
				return RogueMagicAutoDressInMagicUnitChangeScNotify._parser;
			}
		}

		// Token: 0x17002F75 RID: 12149
		// (get) Token: 0x0600A7F7 RID: 42999 RVA: 0x001C47D0 File Offset: 0x001C29D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueMagicAutoDressInMagicUnitChangeScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002F76 RID: 12150
		// (get) Token: 0x0600A7F8 RID: 43000 RVA: 0x001C47E2 File Offset: 0x001C29E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueMagicAutoDressInMagicUnitChangeScNotify.Descriptor;
			}
		}

		// Token: 0x0600A7F9 RID: 43001 RVA: 0x001C47E9 File Offset: 0x001C29E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicAutoDressInMagicUnitChangeScNotify()
		{
		}

		// Token: 0x0600A7FA RID: 43002 RVA: 0x001C47F1 File Offset: 0x001C29F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicAutoDressInMagicUnitChangeScNotify(RogueMagicAutoDressInMagicUnitChangeScNotify other) : this()
		{
			this.enableAutoDress_ = other.enableAutoDress_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A7FB RID: 43003 RVA: 0x001C4816 File Offset: 0x001C2A16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicAutoDressInMagicUnitChangeScNotify Clone()
		{
			return new RogueMagicAutoDressInMagicUnitChangeScNotify(this);
		}

		// Token: 0x17002F77 RID: 12151
		// (get) Token: 0x0600A7FC RID: 43004 RVA: 0x001C481E File Offset: 0x001C2A1E
		// (set) Token: 0x0600A7FD RID: 43005 RVA: 0x001C4826 File Offset: 0x001C2A26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool EnableAutoDress
		{
			get
			{
				return this.enableAutoDress_;
			}
			set
			{
				this.enableAutoDress_ = value;
			}
		}

		// Token: 0x0600A7FE RID: 43006 RVA: 0x001C482F File Offset: 0x001C2A2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueMagicAutoDressInMagicUnitChangeScNotify);
		}

		// Token: 0x0600A7FF RID: 43007 RVA: 0x001C483D File Offset: 0x001C2A3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueMagicAutoDressInMagicUnitChangeScNotify other)
		{
			return other != null && (other == this || (this.EnableAutoDress == other.EnableAutoDress && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A800 RID: 43008 RVA: 0x001C486C File Offset: 0x001C2A6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EnableAutoDress)
			{
				num ^= this.EnableAutoDress.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A801 RID: 43009 RVA: 0x001C48AB File Offset: 0x001C2AAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A802 RID: 43010 RVA: 0x001C48B3 File Offset: 0x001C2AB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A803 RID: 43011 RVA: 0x001C48BC File Offset: 0x001C2ABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EnableAutoDress)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.EnableAutoDress);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A804 RID: 43012 RVA: 0x001C48F0 File Offset: 0x001C2AF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EnableAutoDress)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A805 RID: 43013 RVA: 0x001C4922 File Offset: 0x001C2B22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueMagicAutoDressInMagicUnitChangeScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EnableAutoDress)
			{
				this.EnableAutoDress = other.EnableAutoDress;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A806 RID: 43014 RVA: 0x001C4953 File Offset: 0x001C2B53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A807 RID: 43015 RVA: 0x001C495C File Offset: 0x001C2B5C
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
					this.EnableAutoDress = input.ReadBool();
				}
			}
		}

		// Token: 0x040044AF RID: 17583
		private static readonly MessageParser<RogueMagicAutoDressInMagicUnitChangeScNotify> _parser = new MessageParser<RogueMagicAutoDressInMagicUnitChangeScNotify>(() => new RogueMagicAutoDressInMagicUnitChangeScNotify());

		// Token: 0x040044B0 RID: 17584
		private UnknownFieldSet _unknownFields;

		// Token: 0x040044B1 RID: 17585
		public const int EnableAutoDressFieldNumber = 1;

		// Token: 0x040044B2 RID: 17586
		private bool enableAutoDress_;
	}
}
