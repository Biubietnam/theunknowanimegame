using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200053F RID: 1343
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightLeaveScNotify : IMessage<FightLeaveScNotify>, IMessage, IEquatable<FightLeaveScNotify>, IDeepCloneable<FightLeaveScNotify>, IBufferMessage
	{
		// Token: 0x17001116 RID: 4374
		// (get) Token: 0x06003BDB RID: 15323 RVA: 0x000A457C File Offset: 0x000A277C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightLeaveScNotify> Parser
		{
			get
			{
				return FightLeaveScNotify._parser;
			}
		}

		// Token: 0x17001117 RID: 4375
		// (get) Token: 0x06003BDC RID: 15324 RVA: 0x000A4583 File Offset: 0x000A2783
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FightLeaveScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001118 RID: 4376
		// (get) Token: 0x06003BDD RID: 15325 RVA: 0x000A4595 File Offset: 0x000A2795
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FightLeaveScNotify.Descriptor;
			}
		}

		// Token: 0x06003BDE RID: 15326 RVA: 0x000A459C File Offset: 0x000A279C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightLeaveScNotify()
		{
		}

		// Token: 0x06003BDF RID: 15327 RVA: 0x000A45A4 File Offset: 0x000A27A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightLeaveScNotify(FightLeaveScNotify other) : this()
		{
			this.hGJPICGMLMK_ = other.hGJPICGMLMK_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003BE0 RID: 15328 RVA: 0x000A45C9 File Offset: 0x000A27C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightLeaveScNotify Clone()
		{
			return new FightLeaveScNotify(this);
		}

		// Token: 0x17001119 RID: 4377
		// (get) Token: 0x06003BE1 RID: 15329 RVA: 0x000A45D1 File Offset: 0x000A27D1
		// (set) Token: 0x06003BE2 RID: 15330 RVA: 0x000A45D9 File Offset: 0x000A27D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint HGJPICGMLMK
		{
			get
			{
				return this.hGJPICGMLMK_;
			}
			set
			{
				this.hGJPICGMLMK_ = value;
			}
		}

		// Token: 0x06003BE3 RID: 15331 RVA: 0x000A45E2 File Offset: 0x000A27E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FightLeaveScNotify);
		}

		// Token: 0x06003BE4 RID: 15332 RVA: 0x000A45F0 File Offset: 0x000A27F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FightLeaveScNotify other)
		{
			return other != null && (other == this || (this.HGJPICGMLMK == other.HGJPICGMLMK && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003BE5 RID: 15333 RVA: 0x000A4620 File Offset: 0x000A2820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HGJPICGMLMK != 0U)
			{
				num ^= this.HGJPICGMLMK.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003BE6 RID: 15334 RVA: 0x000A465F File Offset: 0x000A285F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003BE7 RID: 15335 RVA: 0x000A4667 File Offset: 0x000A2867
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003BE8 RID: 15336 RVA: 0x000A4670 File Offset: 0x000A2870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HGJPICGMLMK != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.HGJPICGMLMK);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003BE9 RID: 15337 RVA: 0x000A46A4 File Offset: 0x000A28A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HGJPICGMLMK != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.HGJPICGMLMK);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003BEA RID: 15338 RVA: 0x000A46E2 File Offset: 0x000A28E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FightLeaveScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HGJPICGMLMK != 0U)
			{
				this.HGJPICGMLMK = other.HGJPICGMLMK;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003BEB RID: 15339 RVA: 0x000A4713 File Offset: 0x000A2913
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003BEC RID: 15340 RVA: 0x000A471C File Offset: 0x000A291C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.HGJPICGMLMK = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001814 RID: 6164
		private static readonly MessageParser<FightLeaveScNotify> _parser = new MessageParser<FightLeaveScNotify>(() => new FightLeaveScNotify());

		// Token: 0x04001815 RID: 6165
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001816 RID: 6166
		public const int HGJPICGMLMKFieldNumber = 14;

		// Token: 0x04001817 RID: 6167
		private uint hGJPICGMLMK_;
	}
}
