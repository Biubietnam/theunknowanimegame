using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000FB3 RID: 4019
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournExpNotify : IMessage<RogueTournExpNotify>, IMessage, IEquatable<RogueTournExpNotify>, IDeepCloneable<RogueTournExpNotify>, IBufferMessage
	{
		// Token: 0x17003280 RID: 12928
		// (get) Token: 0x0600B316 RID: 45846 RVA: 0x001E11FC File Offset: 0x001DF3FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournExpNotify> Parser
		{
			get
			{
				return RogueTournExpNotify._parser;
			}
		}

		// Token: 0x17003281 RID: 12929
		// (get) Token: 0x0600B317 RID: 45847 RVA: 0x001E1203 File Offset: 0x001DF403
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournExpNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003282 RID: 12930
		// (get) Token: 0x0600B318 RID: 45848 RVA: 0x001E1215 File Offset: 0x001DF415
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournExpNotify.Descriptor;
			}
		}

		// Token: 0x0600B319 RID: 45849 RVA: 0x001E121C File Offset: 0x001DF41C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournExpNotify()
		{
		}

		// Token: 0x0600B31A RID: 45850 RVA: 0x001E1224 File Offset: 0x001DF424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournExpNotify(RogueTournExpNotify other) : this()
		{
			this.exp_ = other.exp_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B31B RID: 45851 RVA: 0x001E1249 File Offset: 0x001DF449
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournExpNotify Clone()
		{
			return new RogueTournExpNotify(this);
		}

		// Token: 0x17003283 RID: 12931
		// (get) Token: 0x0600B31C RID: 45852 RVA: 0x001E1251 File Offset: 0x001DF451
		// (set) Token: 0x0600B31D RID: 45853 RVA: 0x001E1259 File Offset: 0x001DF459
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Exp
		{
			get
			{
				return this.exp_;
			}
			set
			{
				this.exp_ = value;
			}
		}

		// Token: 0x0600B31E RID: 45854 RVA: 0x001E1262 File Offset: 0x001DF462
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournExpNotify);
		}

		// Token: 0x0600B31F RID: 45855 RVA: 0x001E1270 File Offset: 0x001DF470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournExpNotify other)
		{
			return other != null && (other == this || (this.Exp == other.Exp && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B320 RID: 45856 RVA: 0x001E12A0 File Offset: 0x001DF4A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Exp != 0U)
			{
				num ^= this.Exp.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B321 RID: 45857 RVA: 0x001E12DF File Offset: 0x001DF4DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B322 RID: 45858 RVA: 0x001E12E7 File Offset: 0x001DF4E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B323 RID: 45859 RVA: 0x001E12F0 File Offset: 0x001DF4F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Exp != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.Exp);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B324 RID: 45860 RVA: 0x001E1324 File Offset: 0x001DF524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Exp != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Exp);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B325 RID: 45861 RVA: 0x001E1362 File Offset: 0x001DF562
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournExpNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Exp != 0U)
			{
				this.Exp = other.Exp;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B326 RID: 45862 RVA: 0x001E1393 File Offset: 0x001DF593
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B327 RID: 45863 RVA: 0x001E139C File Offset: 0x001DF59C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Exp = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040048BD RID: 18621
		private static readonly MessageParser<RogueTournExpNotify> _parser = new MessageParser<RogueTournExpNotify>(() => new RogueTournExpNotify());

		// Token: 0x040048BE RID: 18622
		private UnknownFieldSet _unknownFields;

		// Token: 0x040048BF RID: 18623
		public const int ExpFieldNumber = 9;

		// Token: 0x040048C0 RID: 18624
		private uint exp_;
	}
}
